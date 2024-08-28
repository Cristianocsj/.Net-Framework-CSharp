using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDeAula.Classes
{
    abstract class ContaComum
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }

        public ContaComum()
        {
        }

        public ContaComum(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public virtual void Saque(double valor)
        {
            Saldo -= valor + 5.0;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public override string ToString()
        {
            return "Numero da Conta: " + Numero +
            "\nTitular: " + Titular +
            "\nSaldo: " + Saldo;

        }
    }
}
