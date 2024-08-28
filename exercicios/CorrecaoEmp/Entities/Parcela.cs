using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CorrecaoEmp.Entities
{
    internal class Parcela
    {
        public DateTime DataVencimento { get; set; }
        public double Valor { get; set; }

        public Parcela(DateTime dataVencimento, double valor)
        {
            DataVencimento = dataVencimento;
            Valor = valor;
        }

        public override string ToString()
        { 
            return DataVencimento.ToString("dd/MM/yyyy") + " - " + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
