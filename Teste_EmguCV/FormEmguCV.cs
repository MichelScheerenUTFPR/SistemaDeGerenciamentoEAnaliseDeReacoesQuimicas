using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Teste_EmguCV.Modelo;
using ZedGraph;

namespace Teste_EmguCV
{
    public partial class FormEmguCV : Form
    {
        //Variáveis Globais
        private WebCam _webCam;
        private DesenharRetangulo _retangulo;
        private Analise _analise;

        //NOVO
        GraphPane grafico;

        public FormEmguCV()
        {
            InitializeComponent();
        }

        //No carregamento da página, faz as intanciações necessárias
        private void FormEmguCV_Load(object sender, EventArgs e)
        {
            _webCam = new WebCam(pbCapturaWebCam);
            _webCam.WebCamThread.Start();
            _retangulo = new DesenharRetangulo();
            _analise = new Analise();

            //NOVO
            grafico = graficoAnalise.GraphPane;
        }

        //Garantir que a Thread da WebCam seja fechada
        private void FormEmguCV_FormClosing(object sender, FormClosingEventArgs e)
        {
            _webCam.Encerrar(); 
        }

        //Eventos necessários para o retângulo desenhado na tela
        private void PbCapturaWebCam_MouseDown(object sender, MouseEventArgs e)
        {
            _retangulo.MouseDown(e.Location);
        }
        private void PbCapturaWebCam_MouseMove(object sender, MouseEventArgs e)
        {
            _retangulo.MouseMove(e.Location, pbCapturaWebCam);
        }
        private void PbCapturaWebCam_Paint(object sender, PaintEventArgs e)
        {
            _retangulo.Paint(e.Graphics);
        }
        private void PbCapturaWebCam_MouseUp(object sender, MouseEventArgs e)
        {
            _retangulo.MouseUp(e.Location);
        }

        private void BtnRetanguloManual_Click(object sender, EventArgs e)
        {
            try
            {
                _retangulo.RetanguloManual(txtX1.Text, txtY1.Text, txtX2.Text, txtY2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Um ou mais pontos inválidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void BtnObterDiferenciador_Click(object sender, EventArgs e)
        {
            _analise.ObterDiferenciador(_webCam.Matriz.ToImage<Bgr, byte>(), _retangulo.Retangulo);
            txtBlue.Text = Convert.ToString(_analise.Diferenciador.Blue);
            txtGreen.Text = Convert.ToString(_analise.Diferenciador.Green);
            txtRed.Text = Convert.ToString(_analise.Diferenciador.Red);
        }

        private async void BtnIniciarCapturas_Click(object sender, EventArgs e)
        {
            await Task.Run(() => _analise.IniciarAnalise(nudTempo.Value, nudCapturas.Value, _webCam, _retangulo.Retangulo));
            _analise.Sinais.ForEach(x => rtxtSinais.AppendText(x + "\n"));
            AtualizarGrafico();
        }

        private void AtualizarGrafico()
        {
            for (int i = 0; i < _analise.Sinais.Count; i++)
            {
                graficoResultados.Series[0].Points.AddXY(i + 1, _analise.Sinais[i]);
            }
        }
    }
}
