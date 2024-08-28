using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace av1.Classes
{
    internal class PFisica : Pessoa
    {
        public double GastosSaude { get; private set; }

        public PFisica(string nome, double r_anual) : base(nome, r_anual)
        {
        }
        public PFisica(string nome, double r_anual, double g_saude) : base(nome, r_anual)
        {
            GastosSaude = g_saude;
        }

        public override double CalculoImp()
        {
            double calculo = 0;

            if (RendaAnual < 20000)
            {
                calculo = (RendaAnual * 0.15) - (GastosSaude * 0.5);
            }
            else if (RendaAnual >= 20000)
            {
                calculo = (RendaAnual * 0.25) - (GastosSaude * 0.5);
            }

            return calculo;
        }
    }
}
