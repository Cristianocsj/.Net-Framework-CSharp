using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDeAula.Classes
{
    class ContaPoupanca : ContaComum;
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
            base.Saque(valor);
            Saldo -= 2.0;
        }

        public override string ToString()
        {
            return "Numero da Conta: " + Numero +
            "\nTitular: " + Titular +
            "\nSaldo: " + Saldo +
            "\nLimite TaxaJuros: " + TaxaJuros;
        }
    }
}
}
