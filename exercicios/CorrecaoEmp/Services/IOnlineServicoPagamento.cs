using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrecaoEmp.Services
{
    internal interface IOnlineServicoPagamento
    {
        double TaxaPagamento(double valor);
        double Juros(double valor, int meses);
    }
}
