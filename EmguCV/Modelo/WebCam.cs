using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_EmguCV.Modelo
{
    class WebCam
    {
        public VideoCapture Captura { get; private set; }

        public Thread WebCamThread { get; private set; }

        public Mat Matriz { get; private set; }

        public PictureBox PbWebCam { get; set; }

        public int WebCamAtual { get; set; }

        public WebCam(PictureBox pictureBox)
        {
            Matriz = new Mat();
            Captura = new VideoCapture(0);
            WebCamAtual = 0;
            WebCamThread = new Thread(ExibirImagemWebCam){Priority = ThreadPriority.Highest};
            PbWebCam = pictureBox;
            WebCamThread.Start();
        }

        private void ExibirImagemWebCam()
        {
            while (Captura.IsOpened)
            {
                Matriz = Captura.QueryFrame();
                PbWebCam.Image = Matriz.Bitmap;
            }
        }

        public void Encerrar()
        {
            WebCamThread.Abort();
            Captura.Dispose();
        }

        public void TestarOutrasCameras(MenuStrip menu)
        {
            menu.Items.Add("WebCam principal");
            int camera = 1;
            while (camera != -1)
            {
                VideoCapture aux = new VideoCapture(camera);
                if (aux.IsOpened)
                {
                    camera++;
                    menu.Items.Add("WebCam " + camera);
                }
                else
                {
                    camera = -1;
                }
                aux.Dispose();
            }
        }

        public async Task MudarWebCam(int indice)
        {
            VideoCapture captureAux = Captura;
            Thread threadAux = WebCamThread;
            Captura = new VideoCapture(indice);
            WebCamAtual = indice;
            WebCamThread = new Thread(ExibirImagemWebCam) { Priority = ThreadPriority.Highest };
            await Task.Run(() => WebCamThread.Start());
            await Task.Run(() => threadAux.Abort());
            captureAux.Dispose();
        }
    }
}
