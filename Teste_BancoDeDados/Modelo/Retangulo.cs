using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_EmguCV.Modelo
{
    class Retangulo
    {
        public Rectangle RetanguloDesenhado { get; set; }
        public Point PosicaoInicial { get; set; }
        public Point PosicaoFinal { get; set; }
        public bool MousePressionado { get; set; }

        public Retangulo()
        {
            MousePressionado = false;
            RetanguloDesenhado = new Rectangle();
        }

        public void DesenharRetangulo()
        {
            Rectangle rect = new Rectangle();
            rect.X = Math.Min(PosicaoInicial.X, PosicaoFinal.X);
            rect.Y = Math.Min(PosicaoInicial.Y, PosicaoFinal.Y);
            rect.Width = Math.Abs(PosicaoInicial.X - PosicaoFinal.X);
            rect.Height = Math.Abs(PosicaoInicial.Y - PosicaoFinal.Y);
            RetanguloDesenhado = rect;
        }

        public int Altura()
        {
            return RetanguloDesenhado.Height;
        }
        public int Largura()
        {
            return RetanguloDesenhado.Width;
        }


    }
}
