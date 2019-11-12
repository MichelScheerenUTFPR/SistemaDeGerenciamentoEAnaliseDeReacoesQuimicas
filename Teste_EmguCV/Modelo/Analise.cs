using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_EmguCV.Modelo
{
    class Analise
    {
        public Bgr Diferenciador { get; set; }
        public List<Bgr> Capturas { get; set; }
        public List<double> Sinais { get; set; }
        public TimeSpan Intervalo { get; set; }
        public int Repetições { get; set; }

        public Analise()
        {
            Diferenciador = new Bgr();
            Capturas = new List<Bgr>();
            Sinais = new List<double>();
            Intervalo = new TimeSpan();
        }

        public void ObterDiferenciador(Image<Bgr, byte> imagem, Rectangle retangulo)
        {
            if(retangulo.Width != 0 && retangulo.Height != 0)
            {
                imagem = imagem.GetSubRect(retangulo);

            }
            Diferenciador = imagem.GetAverage();
        }

        public async Task IniciarAnalise(decimal tempo, decimal numCapturas, WebCam webCam, Rectangle retangulo)
        {
            Repetições = Convert.ToInt32(tempo * numCapturas);
            Intervalo = TimeSpan.FromMilliseconds(1000 / Convert.ToInt32(numCapturas));
            for (int i = 0; i <= Repetições; i++)
            {
                Capturas.Add(webCam.Matriz.ToImage<Bgr, byte>().GetSubRect(retangulo).GetAverage());
                await Task.Delay(Intervalo);
            }
            CalcularSinal();
        }

        private void CalcularSinal()
        {
            for (int i = 0; i < Repetições; i++)
            {
                Sinais.Add(Math.Sqrt(Math.Pow(Capturas[i].Blue - Diferenciador.Blue, 2) +
                                         Math.Pow(Capturas[i].Green - Diferenciador.Green, 2) +
                                         Math.Pow(Capturas[i].Red - Diferenciador.Red, 2)));
            }
        }
    }
}
