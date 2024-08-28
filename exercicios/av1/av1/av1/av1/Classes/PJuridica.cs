using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace av1.Classes
{
    internal class PJuridica : Pessoa
    {
        public int NFunc { get; private set; }

        public PJuridica(string nome, double r_anual, int n_func) : base(nome, r_anual)
        {
            NFunc = n_func;
        }

        public override double CalculoImp()
        {
            double calculo = RendaAnual * 0.16;

            if (NFunc > 10)
            {
                calculo = RendaAnual * 0.14;
            }
            return calculo;
        }
    }
}
