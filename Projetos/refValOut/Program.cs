using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refValOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triplo;
            Calculadora.Triplo(a out triplo);
            Console.WriteLine(triplo);
            Console.ReadKey();
        }
    }
}
