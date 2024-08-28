using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrecaoEmp.Services
{
    internal class PayPalService : IOnlineServicoPagamento
    {
        private const double TaxaPrcentagem = 0.02;
        private const double JurosMensais = 0.01;

        public double Juros(double valor, int meses)
        {
            return valor * JurosMensais * meses;
        }

        public double TaxaPagamento (double valor)
        {
            return valor * TaxaPrcentagem;
        }
    }
}
