using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int cris;
            cris = 18;
            float correa = cris;
            */

            float a = 4.953f;
            int b = Convert.ToInt32(a); // Casting = arredonda o número da variável a para 5
            Console.WriteLine(b);
            //Console.WriteLine(correa);
            Console.ReadKey();
        }
    }
}
