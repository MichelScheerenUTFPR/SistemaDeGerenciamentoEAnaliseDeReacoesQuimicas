using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Teste_EmguCV.Modelo;
using Teste_EmguCV.Persistencia;

namespace Teste_EmguCV
{
    public partial class FormEmguCV : Form
    {
        //Variáveis Globais
        private WebCam _webCam;
        private DesenharRetangulo _retangulo;
        private Analise _analise;

        public FormEmguCV()
        {
            InitializeComponent();
        }

        //No carregamento da página, faz as intanciações necessárias
        private async void FormEmguCV_Load(object sender, EventArgs e)
        {
            _webCam = new WebCam(pbCapturaWebCam);
            _webCam.TestarOutrasCameras(menuWebCam);
            _retangulo = new DesenharRetangulo();
            _analise = new Analise();
            await Task.Run(() => CreateDataBase.Verify());
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

        //Inserir o retângulo manualmente
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

        //Iniciar captura do diferenciador
        private void BtnObterDiferenciador_Click(object sender, EventArgs e)
        {
            if (_retangulo.Altura() != 0 && _retangulo.Largura() != 0)
            {
                _analise.ObterDiferenciador(_webCam.Matriz.ToImage<Bgr, byte>(), _retangulo.Retangulo);
                txtBlue.Text = Convert.ToString(_analise.Diferenciador.Blue);
                txtGreen.Text = Convert.ToString(_analise.Diferenciador.Green);
                txtRed.Text = Convert.ToString(_analise.Diferenciador.Red);
                btnIniciarCapturas.Enabled = true;
            }
            else
            {
                MessageBox.Show("Para iniciar a análise é preciso selecionar uma área de interesse na imagem!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Iniciar capturas para a análise
        private async void BtnIniciarCapturas_Click(object sender, EventArgs e)
        {
            if (_retangulo.Altura() != 0 && _retangulo.Largura() != 0)
            {
                
                await Task.Run(() => _analise.IniciarAnalise(nudTempo.Value, nudCapturas.Value, _webCam, _retangulo.Retangulo));
                AtualizarComponentes();
                
            }
            else
            {
                MessageBox.Show("Para iniciar a análise é preciso selecionar uma área de interesse na imagem!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AtualizarComponentes()
        {
            rtxtSinais.Clear();
            graficoResultados.Series[0].Points.Clear();
            for (int i = 0; i < _analise.Sinais.Count; i++)
            {
                rtxtSinais.AppendText(_analise.Sinais[i] + "\n");
                graficoResultados.Series[0].Points.AddXY(i + 1, _analise.Sinais[i]);
            }
        }

        //Alternar entra WebCams
        private async void MenuWebCam_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int indice = menuWebCam.Items.IndexOf(e.ClickedItem);
            if (indice != _webCam.WebCamAtual)
            {
                menuWebCam.Enabled = false;
                await Task.Run(() => _webCam.MudarWebCam(indice));
                menuWebCam.Enabled = true;
            }
            
        }

        private void BtnCaminhoPlanilha_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserPlanilha.ShowDialog();
            if(result == DialogResult.OK)
            {
                txtBoxCaminhoPlanilha.Text = folderBrowserPlanilha.SelectedPath;
            }
        }

        private void BtnGerarPlanilha_Click(object sender, EventArgs e)
        {
            GeradorPlanilha gerador = new GeradorPlanilha();
            string path = txtBoxCaminhoPlanilha.Text + "/" + txtBoxNomePlanilha.Text + ".xlsx";
            var dados = new List<object[]>();
            for(int i = 0; i < _analise.Repetições; i++)
            {
                dados.Add(new object[] { _analise.Capturas[i].Red, _analise.Capturas[i].Green, _analise.Capturas[i].Blue, _analise.Sinais[i] });
            }

            if(string.IsNullOrEmpty(txtBoxCaminhoPlanilha.Text) || string.IsNullOrEmpty(txtBoxNomePlanilha.Text)){
                MessageBox.Show("Existem campos vazios. Preencha-os corretamente para gerar a planilha.");
            } else if (!System.IO.File.Exists(path))
            {
                gerador.gerarPlanilha(dados, path);
            } else if(MessageBox.Show("Um arquivo com esse nome já existe. Deseja sobrescrevê-lo?", "Aviso", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                gerador.gerarPlanilha(dados, path);
            }
        }
    }
}
