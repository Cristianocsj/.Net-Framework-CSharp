using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o raio da circunfêrencia: ");
            double raio = double.Parse(Console.ReadLine());

            double pi = 3.14159;
            double area = Math.Pow(raio, 2) * pi; //Math.Pow(raio, 2) é igual a raio elevado à 2

            Console.WriteLine($"Área = {area:N4}");
            Console.ReadKey();
        }
    }
}
