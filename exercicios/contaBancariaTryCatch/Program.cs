using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contaBancariaTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Número da conta: ");
                int num = int.Parse(Console.ReadLine());

                Console.Write("Nome do titular: ");
                string titular = Console.ReadLine();

                Console.Write("Saldo inicial: ");
                double saldo = double.Parse(Console.ReadLine());

                Console.Write("Limite de saque: ");
                double limiteSaque = double.Parse(Console.ReadLine());

                ContaBancaria conta = new ContaBancaria(num, titular, saldo, limiteSaque);

                Console.Write("Digite o valor para depósito: ");
                double valorDeposito = double.Parse(Console.ReadLine());
                conta.Deposito(valorDeposito);

                Console.Write("Digite o valor para saque: ");
                double valorSaque = double.Parse(Console.ReadLine());
                conta.Saque(valorSaque);

                Console.WriteLine(conta.ToString());
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro de formato: por favor, insira números válidos.");
            }
            Console.ReadKey();
        }
    }
}
