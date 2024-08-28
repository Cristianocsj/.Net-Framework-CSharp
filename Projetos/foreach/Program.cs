using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[] { "Marcos", "Filipe", "Maria" };
            /*
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }
            */
            foreach (string n1 in nomes)
            {
                Console.WriteLine(n1);
            }
            Console.ReadKey();
        }
    }
}
