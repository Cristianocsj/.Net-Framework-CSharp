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
            /*
            int i = 3;
            Console.WriteLine(i);
            Console.WriteLine(i++); //O ++ sendo utilizado depois da variável quer dizer que a proxima linha será incrementada
            Console.WriteLine(i);
            */
            double a = 1.5;
            Console.WriteLine(a);
            Console.WriteLine(++a); //O ++ sendo utilizado antes da variável quer dizer que o incremento acontece na mesma linha
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
