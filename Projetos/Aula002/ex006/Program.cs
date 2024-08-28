using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ex006
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int a;
            a = int.Parse(Console.ReadLine()); // Console.ReadLine só lê em valores string, para ler um valor inteiro, foi preciso utilizar o comando int.Parse
            Console.WriteLine(a);
            int num;
            num = Convert.ToInt32(Console.ReadLine()); // mesma situaação apontada emcima
            Console.WriteLine(num);
           */
            int valor = 0;
            int.TryParse(Console.ReadLine(), out valor);
            Console.WriteLine(valor);

            Console.ReadKey();
        }
    }
}
