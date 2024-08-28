using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota=6;
            string resultado;
            if (nota >= 7)
            {
                resultado = "Aprovado";
                Console.WriteLine(resultado);
                Console.WriteLine("Parabéns!");
            }
            else if (nota >= 5 && nota < 7)
            {
                resultado = "Recuperação";
                Console.WriteLine(resultado);
                Console.WriteLine("Boa sorte!");
            }
            else
            {
                resultado = "Reprovado";
                Console.WriteLine(resultado);
                Console.WriteLine("Estude Mais!");
            }
            Console.ReadKey();
        }
    }
}
