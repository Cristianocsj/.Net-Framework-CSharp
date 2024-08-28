using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            float n2 = float.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            float n3 = float.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            float n4 = float.Parse(Console.ReadLine());

            float media = (n1 + n2 + n3 + n4)/4;

            Console.WriteLine("A média aritmética entre os números digitados foi " + media);
            Console.ReadKey();
        }
    }
}
