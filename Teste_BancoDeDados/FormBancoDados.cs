
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

using Teste_EmguCV.Modelo;
using Teste_EmguCV.Persistencia;

namespace Teste_EmguCV
{
    public partial class FormBancoDados : Form
    {
        private VideoCapture _capture;
        private Thread _captureThread;
        private Imagem _imagem; //Pro banco de Dados
        private Mat _mat;
        private Retangulo _retangulo;

        public FormBancoDados()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _retangulo = new Retangulo();
            _mat = new Mat();
            _capture = new VideoCapture();
            _captureThread = new Thread(DisplayWebcam);
            _captureThread.Priority = ThreadPriority.Highest;
            _captureThread.Start();
        }

        private void DisplayWebcam()
        {
            while (_capture.IsOpened)
            {
                Mat frame = _capture.QueryFrame();
                CvInvoke.Resize(frame, _mat, pbWebCam.Size);
                pbWebCam.Image = _mat.Bitmap;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _captureThread.Abort();
            _capture.Dispose();
        }

        private void BtnCapturarImagem_Click(object sender, EventArgs e)
        {
            Mat frame = _capture.QueryFrame();
            CvInvoke.Resize(frame, frame, pbWebCam.Size);
            pbCaptura.Image = frame.Bitmap;
        }

        private void BtnCortar_Click(object sender, EventArgs e)
        {
            if(_retangulo.Altura() != 0 && _retangulo.Largura() != 0)
            {
                Image<Bgr, Byte> img2 = _mat.ToImage<Bgr, Byte>();
                img2 = img2.GetSubRect(_retangulo.RetanguloDesenhado);
                pbCaptura.Image = img2.Bitmap;
            }
        }

        private void BtnObterDosArquivos_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Mat mat = CvInvoke.Imread(fileDialog.FileName, ImreadModes.AnyColor);
                CvInvoke.Resize(mat, mat, pbObter.Size);
                pbObter.Image = mat.Bitmap;
                Bitmap bitmap = new Bitmap(mat.Bitmap);
                MemoryStream ms = new MemoryStream();
                bitmap.Save(ms, ImageFormat.Png);
                _imagem = new Imagem(ms.ToArray(), fileDialog.SafeFileName);
            }
        }

        private async void BtnGravarBanco_Click(object sender, EventArgs e)
        {
            CondicoesGravacao(false, "Aguarde...!", true, Color.Red);
            await Task.Run(() => GravarBanco());
            CondicoesGravacao(true, "Operação Concluída!", true, Color.Green);
            await Task.Delay(5000);
            lblResultadoGravacao.Visible = false;
        }

        private void CondicoesGravacao(bool botaoEnable, string lblText, bool lblVisible, Color lblCor)
        {
            btnGravarBanco.Enabled = botaoEnable;
            lblResultadoGravacao.Text = lblText;
            lblResultadoGravacao.Visible = lblVisible;
            lblResultadoGravacao.ForeColor = lblCor;
        }

        private void GravarBanco()
        {
            DBContext context = new DBContext();
            context.Imagens.Add(_imagem);
            context.SaveChanges();
            context.Dispose();
        }

        private async void btnPegarBanco_Click(object sender, EventArgs e)
        {
            await Task.Run(() => PegarBanco());
        }

        private void PegarBanco()
        {
            DBContext context = new DBContext();
            int tamanho = context.Imagens.Count();
            Random random = new Random((int)DateTime.Now.Ticks);
            List<Imagem> busca = context.Imagens.ToList();
            Imagem aleatoria = busca.ElementAt((random.Next() % tamanho));
            if(aleatoria != null)
            {
                _imagem = new Imagem(aleatoria.Dados, aleatoria.Nome);
                MemoryStream ms = new MemoryStream(_imagem.Dados, 0, _imagem.Dados.Length);
                Image image = Image.FromStream(ms);
                pbObter.Image = image;                
            }
            context.Dispose();
        }

        //Desenhar Retangulo:
        private void PbWebCam_MouseDown(object sender, MouseEventArgs e)
        {
            _retangulo.PosicaoFinal = Point.Empty;
            _retangulo.MousePressionado = true;
            _retangulo.PosicaoInicial = e.Location;
        }
        private void PbWebCam_MouseMove(object sender, MouseEventArgs e)
        {
            if (_retangulo.MousePressionado == true)
            {
                _retangulo.PosicaoFinal = e.Location;
                pbWebCam.Invalidate();
            }
        }
        private void PbWebCam_Paint(object sender, PaintEventArgs e)
        {
            if (!_retangulo.PosicaoInicial.IsEmpty && !_retangulo.PosicaoFinal.IsEmpty)
            {
                _retangulo.DesenharRetangulo();
                e.Graphics.DrawRectangle(Pens.Red, _retangulo.RetanguloDesenhado);
            }
        }
        private void PbWebCam_MouseUp(object sender, MouseEventArgs e)
        {
            if (_retangulo.MousePressionado == true)
            {
                _retangulo.PosicaoFinal = e.Location;
                _retangulo.MousePressionado = false;
            }
        }
    }
}
