using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02.Classes
{
    class Retangulo : Figura
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura, string cor): base(cor)
        {
            Largura = largura;
            Altura = altura;
        }

        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
