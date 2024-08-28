using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial na conta? (s/n): ");
            char resp = char.Parse(Console.ReadLine());
            Console.WriteLine();

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double depInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, depInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("Dados da conta ");
            Console.WriteLine(conta.Numero);
            Console.WriteLine(conta.Titular);
            Console.WriteLine($"{conta.Saldo:C2}");
            Console.WriteLine();

            Console.Write("Entre com um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine());
            conta.Depositar(quantia);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta.Numero);
            Console.WriteLine(conta.Titular);
            Console.WriteLine($"{conta.Saldo:C2}");
            Console.WriteLine();

            Console.Write("Entre com um valor do saque: ");
            double ret = double.Parse(Console.ReadLine());
            conta.Sacar(ret);
            Console.WriteLine("Dados da conta ");
            Console.WriteLine(conta.Numero);
            Console.WriteLine(conta.Titular);
            Console.WriteLine($"{conta.Saldo:C2}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
