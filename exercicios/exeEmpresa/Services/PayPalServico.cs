using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exeEmpresa.Entities;

namespace exeEmpresa.Services
{
    internal class PayPalServico : IOnlineServicoPagamento
    {
        public double _taxaPagamento { get;private set; }
        public double _juros { get;private set; }

        public PayPalServico(double taxaPagamento, double juros)
        {
            _taxaPagamento = taxaPagamento;
            _juros = juros;
        }

        public double CalcularValorParcela(double valorBase, int meses)
        {
            double valorComJuros = valorBase * Math.Pow(1 + _juros / 100, meses);
            double valorComTaxa = valorComJuros + (valorComJuros * _taxaPagamento / 100);
            return valorComTaxa;
        }
    }

}

