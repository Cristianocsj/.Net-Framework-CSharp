using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.Write("Digite o primeiro valor: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            b = int.Parse(Console.ReadLine());

            int soma = a + b;
            Console.WriteLine("A soma entre os dois números digitados é {0}", soma);
            Console.ReadKey();
        }
    }
}
