using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contaBancariaTryCatch
{
    internal class ContaBancaria
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public ContaBancaria(int numero, string titular, double saldo, double limiteSaque)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Deposito(double valor)
        {
            if(valor <= 0)
            {
                throw new DomainException("O valor do depósito deve ser positivo.");
            }
            else
            {
                Saldo += valor;
            }
        }

        public void Saque(double valor)
        {
            if(valor <= 0)
            {
                throw new DomainException("O valor do saque deve ser positivo.");
            }
            else
            if(valor > LimiteSaque)
            {
                throw new DomainException("O valor requisitado é maior que o seu limíte de saque.");
            }
            else
            if (Saldo < valor)
            {
                throw new DomainException("Impossível sacar o valor requisitado.");
            }
            else
            {
                Saldo -= valor;
            }
        }

        public override string ToString()
        {
            return $" Conta: {Numero}\n Titular: {Titular}\n Saldo: {Saldo:2C}\n Limite de Saque: {LimiteSaque:2C}";
        }



    }
}
