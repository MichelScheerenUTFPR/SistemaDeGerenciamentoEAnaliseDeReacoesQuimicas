using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_EmguCV.Modelo
{
    class DesenharRetangulo
    {
        public Rectangle Retangulo { get; private set; }
        public Point PosicaoInicial { get; private set; }
        public Point PosicaoFinal { get; private set; }
        public bool MousePressionado { get; private set; }

        public DesenharRetangulo()
        {
            Retangulo = new Rectangle(0, 0, 0, 0);
            PosicaoInicial = Point.Empty;
            PosicaoFinal = Point.Empty;
            MousePressionado = false;
        }

        public void MouseDown(Point posicao)
        {
            if(!PosicaoFinal.IsEmpty)
                PosicaoFinal = Point.Empty;

            MousePressionado = true;
            PosicaoInicial = posicao;
        }

        public void MouseMove(Point posicao, PictureBox pbCapturaWebCam)
        {
            if (MousePressionado == true)
            {
                PosicaoFinal = posicao;
                pbCapturaWebCam.Invalidate();
            }
        }

        public void Paint(Graphics paint)
        {
            if (!PosicaoInicial.IsEmpty && !PosicaoFinal.IsEmpty)
            {
                CriarRetangulo();
                paint.DrawRectangle(Pens.Red, Retangulo);
            }
        }

        public void MouseUp(Point posicao)
        {
            if (MousePressionado == true)
            {
                PosicaoFinal = posicao;
                MousePressionado = false;
            }
        }

        private void CriarRetangulo()
        {
            Rectangle rect = new Rectangle();
            rect.X = Math.Min(PosicaoInicial.X, PosicaoFinal.X);
            rect.Y = Math.Min(PosicaoInicial.Y, PosicaoFinal.Y);
            rect.Width = Math.Abs(PosicaoInicial.X - PosicaoFinal.X);
            rect.Height = Math.Abs(PosicaoInicial.Y - PosicaoFinal.Y);
            Retangulo = rect;
        }

        public int Altura()
        {
            return Retangulo.Height;
        }
        public int Largura()
        {
            return Retangulo.Width;
        }

        public void RetanguloManual(string x1, string y1, string x2, string y2)
        {
            PosicaoInicial = new Point(Converter(x1), Converter(y1));
            PosicaoFinal = new Point(Converter(x2), Converter(y2));
        }

        private int Converter(string texto)
        {
            return Convert.ToInt32(texto);
        }
    }
}
