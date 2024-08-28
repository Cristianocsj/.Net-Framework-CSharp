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
            double delta, a, b, c;
            Console.Write("Digite o valor de a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor de c: ");
            c = Convert.ToDouble(Console.ReadLine());

            delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta < 0 && a == 0)
            {
                Console.WriteLine("A equação não possui raízes reais.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"A equação possui uma raiz real: x = {x}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a); //Math.Sqrt foi utilizado para retirar a raiz quadrada de delta
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"A equação possui duas raízes reais: x1 = {x1} e x2 = {x2}");
            }
            Console.ReadKey();
        }
    }
}       