using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace exercicioBoleto
{
    internal class Boleto
    {
        public string Cedente { get; set; }
        public string Descricao { get; set;}
        public double ValorS { get; set; }
        public double ValorTotal { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public double Multa { get; set; }
        public double Juros { get; set; }

        public Boleto(string ced, string desc, double valorS, DateTime dEmissao, DateTime dVencimento, DateTime dPagamento, double valorTot)
        {
            Multa = 100;
            ValorS = valorS;
            Juros = 0.01 * valorS;
            DataEmissao = dEmissao;
            DataVencimento = dVencimento;
            DataPagamento = dPagamento;
            Cedente = ced;
            Descricao = desc;
            ValorTotal = valorS;
        }

        public (double, TimeSpan) CalcularPagamento()
        {
            TimeSpan sub = DataPagamento - DataVencimento;
            if (DataPagamento > DataVencimento)
            {
                ValorTotal = ValorS + Multa + Juros;
            }
            else
            {
                ValorTotal = ValorS;
                sub = TimeSpan.Zero;
            }
            return (ValorTotal, sub);
        }
    }
}
