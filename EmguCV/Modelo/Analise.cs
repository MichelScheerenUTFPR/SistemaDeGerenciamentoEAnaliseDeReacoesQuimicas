using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Teste_EmguCV.Modelo
{
    class Analise
    {
        public Bgr Diferenciador { get; set; }
        public TimeSpan Intervalo { get; set; }
        public int Repetições { get; set; }

        public List<Bgr> Capturas { get; set; }
        public List<double> Sinais { get; set; }
        

        public Analise()
        {
            Diferenciador = new Bgr();
            Capturas = new List<Bgr>();
            Sinais = new List<double>();
            Intervalo = new TimeSpan();
        }

        public void ObterDiferenciador(Image<Bgr, byte> imagem, Rectangle retangulo)
        {
            Diferenciador = imagem.GetSubRect(retangulo).GetAverage();
        }

        public async Task IniciarAnalise(decimal tempo, decimal numCapturas, WebCam webCam, Rectangle retangulo, Chart graficoResultados)
        {
            Repetições = Convert.ToInt32(tempo * numCapturas);
            Intervalo = TimeSpan.FromMilliseconds(1000 / Convert.ToInt32(numCapturas));
            for (int i = 0; i < Repetições; i++)
            {
                Capturas.Add(webCam.Matriz.ToImage<Bgr, byte>().GetSubRect(retangulo).GetAverage());
                CalcularSinal(i);
                AtualizarGrafico(i, graficoResultados);
                await Task.Delay(Intervalo);
            }
        }

        private void CalcularSinal(int posicao)
        {
            Sinais.Add(Math.Sqrt(Math.Pow(Capturas[posicao].Blue - Diferenciador.Blue, 2) +
                                         Math.Pow(Capturas[posicao].Green - Diferenciador.Green, 2) +
                                         Math.Pow(Capturas[posicao].Red - Diferenciador.Red, 2)));
        }

        private void AtualizarGrafico(int posicao, Chart graficoResultados)
        {
            graficoResultados.Series[0].Points.AddXY(posicao + 1, Sinais[posicao]);
            
        }
    }
}
