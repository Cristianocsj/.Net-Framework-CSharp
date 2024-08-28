using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de c: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double areaT = (a * c) / 2;
            double areaC = Math.Pow(c, 2) * 3.14159;
            double areaTra = ((a + b) * c) / 2;
            double areaQua = Math.Pow(b, 2);
            double areaRe = a * b;

            Console.WriteLine("Áreas:");
            Console.WriteLine();
            Console.WriteLine($"Triângulo Retângulo = {areaT}");
            Console.WriteLine($"Circunferência = {areaC}");
            Console.WriteLine($"Trapézio = {areaTra}");
            Console.WriteLine($"Quadrádo = {areaQua}");
            Console.WriteLine($"Retângulo = {areaRe}");

            Console.ReadKey();   
        }
    }
}
