using ex02.NovaPasta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02.Classes
{
    internal class ContaPJ:Conta
    {
        public double LimiteEmprestimo { get; set; }


        public ContaPJ()
        {
            
        }

        public ContaPJ(int numero, string titular, double saldo, double limiteEmprestimo) : base(numero, titular, saldo)
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
            return base.ToString() + "Limite Empréstimo: " + LimiteEmprestimo;
        }
    }
}
