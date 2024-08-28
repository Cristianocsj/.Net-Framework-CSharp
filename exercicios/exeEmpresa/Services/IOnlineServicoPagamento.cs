using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exeEmpresa.Services
{
    internal interface IOnlineServicoPagamento
    {
        double CalcularValorParcela(double valorBase, int meses);
    }
}
