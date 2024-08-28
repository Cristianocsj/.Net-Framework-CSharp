using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex005
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string[] x1 = x.Split(' '); //Divisão do vetor x em N partes, utilizando a tecla " " para delimitar os valores

            Console.WriteLine(x1[0]);
            Console.WriteLine(x1[1]);
            Console.WriteLine(x1[2]);
            Console.ReadKey();
        }
    }
}
