using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace av1.Classes
{
    abstract public class Pessoa
    {
        public string Nome { get; private set; }
        public double RendaAnual { get; protected set; }

        public Pessoa(string nome, double r_anual)
        {
            Nome = nome;
            RendaAnual = r_anual;
        }

        public abstract double CalculoImp();

    }
}
