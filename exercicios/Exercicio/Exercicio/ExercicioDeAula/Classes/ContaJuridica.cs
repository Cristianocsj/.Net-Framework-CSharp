using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDeAula.Classes
{
    class ContaJuridica : ContaComum;
    {
        public double LimiteEmprestimo { get; set; }
        public ContaJuridica()
        {
        }
        public ContaJuridica(int numero, string titular, double saldo, double limiteEmprestimo) : base(numero, titular, saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }
        public void Emprestimo(double valor)
        {
            if (valor <= LimiteEmprestimo)
            {
                Saldo += valor;
            }
        }
        public override string ToString()
        {
            return "Numero da Conta: " + Numero +
            "\nTitular: " + Titular +
            "\nSaldo: " + Saldo +
            "\nLimite Emprestimo: " + LimiteEmprestimo;
        }
    }
}

