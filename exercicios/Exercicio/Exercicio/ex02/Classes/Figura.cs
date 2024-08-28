using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02.Classes
{
    abstract class Figura
    {
        public string Cor { get; set; }

        public Figura(string cor)
        {
            Cor = cor;
        }

        public abstract double Area();
    }
}
