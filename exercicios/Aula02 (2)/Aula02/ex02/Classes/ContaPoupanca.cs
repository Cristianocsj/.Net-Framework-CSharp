using ex02.NovaPasta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02.Classes
{
    internal class ContaPoupanca:Conta
    {
        public double TaxaJuros { get; set; }
        public ContaPoupanca()
        {
        }

        public ContaPoupanca(int numero, string titular, double saldo, double taxajuros)
            : base(numero, titular, saldo)
        {
            TaxaJuros = taxajuros;
        }

        public void AtualizarSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }

        public override void Saque(double valor)
        {
            Saldo -= valor;
        }
        public override string ToString()
        {
            return base.ToString() + "Taxa de juros: " + TaxaJuros;
        }
    }
}
