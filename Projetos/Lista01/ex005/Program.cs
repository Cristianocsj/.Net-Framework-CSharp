using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalPagar;
            Console.Write("O produto que você deseja comprar: ");
            string prod = Console.ReadLine();

            Console.Write("Quantos você pretende levar: ");
            int cont = int.Parse(Console.ReadLine());

            Console.Write("Preço do produto: ");
            double preco = double.Parse(Console.ReadLine());

            totalPagar = cont * preco;

            Console.WriteLine($"Você deseja comprar {cont} {prod}(s) e está disposto à pagar {totalPagar:C} pelo(s) produto(s).");

            Console.ReadKey();
        }
    }
}
