using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Preço do Produto");
            Console.WriteLine("-----------------------------------");
            Console.Write("Produto: ");
            string prod = Console.ReadLine();
            Console.Write("Digite o valor do produto: ");
            float valor = float.Parse(Console.ReadLine());
            Console.Write("Digite o desconto (%): ");
            float desc = float.Parse(Console.ReadLine());

            float tirar = (desc / 100) * valor;
            float novo = valor - tirar;
            Console.WriteLine($"O produto {prod} custava {valor:C2}, com {desc:F2}% de desconto. Passa a custar {novo:C2}");
            Console.ReadKey();
        }
    }
}
