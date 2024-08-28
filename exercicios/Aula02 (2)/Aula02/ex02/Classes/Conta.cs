using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02.NovaPasta
{
    internal class Conta
    {
        public int Numero { get; private set; }//private
        public string Titular { get; private set; } //private
        public double Saldo { get; protected set; } //protected

        public Conta()
        {
        }

        public Conta(int numero, string titular, double saldo)
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
