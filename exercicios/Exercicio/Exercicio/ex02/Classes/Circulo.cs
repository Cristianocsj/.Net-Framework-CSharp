using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02.Classes
{
    class Circulo : Figura;
    {
        public double Raio { get; set; }

        public Circulo(double raio, string cor): base(cor)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return 3.14 * Raio * Raio;
        }
    }
}
