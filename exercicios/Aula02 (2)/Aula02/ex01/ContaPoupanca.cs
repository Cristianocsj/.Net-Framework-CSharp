using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    class ContaPoupanca : Conta
    {
        public double TaxaJuros { get; set; }

        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros):base (numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        public void AtualizarSaldo(double taxaJuros)
        {
            Saldo += Saldo * taxaJuros;
        }

        public override void Sacar(double valor)
        {
            Saldo -= valor;
        }
    }
}
