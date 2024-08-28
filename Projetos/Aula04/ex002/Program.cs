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
            int num;
            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());
            //int ant = num-1;
            //int suc = num+1;
            Console.WriteLine($"Analisando o número {num--} seu antecessor é {num++} e seu sucessor é {++num}");
            
            Console.ReadKey();
        }
    }
}
