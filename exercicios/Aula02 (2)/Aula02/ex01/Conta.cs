using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public virtual void Sacar(double valor)
        {
            Saldo -= valor + 5;
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public override string ToString()
        {
            return $"Número = {Numero} / Títular = {Titular} / Saldo = {Saldo}";
        }
    }
}
