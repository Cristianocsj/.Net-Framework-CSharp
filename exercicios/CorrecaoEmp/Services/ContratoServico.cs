using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorrecaoEmp.Entities;

namespace CorrecaoEmp.Services
{
    internal class ContratoServico
    {
        private IOnlineServicoPagamento _onlineServicoPagamento;

        public ContratoServico(IOnlineServicoPagamento onlineServicoPagamento)
        {
            _onlineServicoPagamento = onlineServicoPagamento;
        }

        public void ProcessarContrato(Contrato contrato, int meses)
        {
            double ParcelaBasica = contrato.ValorTotal / meses;

            for(int i = 1; i <= meses; i++)
            {
                DateTime data = contrato.Data.AddMonths(i);
                double parcelaAtual = ParcelaBasica + _onlineServicoPagamento.Juros(ParcelaBasica, i);
                double parcelaFinal = parcelaAtual + _onlineServicoPagamento.TaxaPagamento(parcelaAtual);
                contrato.AdicionarParcela(new Parcela(data, parcelaFinal));
            }
        }
    }
}
