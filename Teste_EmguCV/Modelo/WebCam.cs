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

        public WebCam(PictureBox pictureBox)
        {
            Captura = new VideoCapture();
            Matriz = new Mat();
            WebCamThread = new Thread(ExibirImagemWebCam);
            WebCamThread.Priority = ThreadPriority.Highest;
            PbWebCam = pictureBox;
        }

        private void ExibirImagemWebCam()
        {
            while (Captura.IsOpened)
            {
                Matriz = Captura.QueryFrame();
                CvInvoke.Resize(Matriz, Matriz, PbWebCam.Size);
                PbWebCam.Image = Matriz.Bitmap;
            }
        }

        public void Encerrar()
        {
            WebCamThread.Abort();
            Captura.Dispose();
        }
    }
}
