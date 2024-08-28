using exeEmpresa.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exeEmpresa.Services
{
    internal class ContratoServico
    {
        private IOnlineServicoPagamento _servicoPagamento;

        public ContratoServico(IOnlineServicoPagamento servicoPagamento)
        {
            _servicoPagamento = servicoPagamento;
        }

        public void ProcessarContrato(Contrato contrato, int numeroDeMeses)
        {
            double valorParcelaBase = contrato.ValorTotal / numeroDeMeses;
            DateTime dataVencimento = contrato.Data.AddMonths(1);

            for (int i = 1; i <= numeroDeMeses; i++)
            {
                double valorFinalParcela = _servicoPagamento.CalcularValorParcela(valorParcelaBase, i);

                Parcela parcela = new Parcela
                {
                    DataVencimento = dataVencimento.AddMonths(i - 1),
                    Valor = valorFinalParcela
                };

                contrato.AdicionarParcela(parcela);
            }
        }
    }
}
