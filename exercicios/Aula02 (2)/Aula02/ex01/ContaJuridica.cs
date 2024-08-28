using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    class ContaJuridica : Conta
    {
        public double  LimiteEmprestimo { get; private set; }
        public ContaJuridica(int numero, string titular, double saldo, double limiteEmprestimo) : base(numero, titular, saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestar(double valor)
        {
            if(valor > LimiteEmprestimo)
            {
                Console.WriteLine("LIMITE ESGOTADO!");
            }
            else
            {
                Saldo += valor;
            }
            
                

        }
    }
}
