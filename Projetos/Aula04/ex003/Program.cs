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
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Média do aluno");
            Console.WriteLine("-----------------------------------");
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a primeira nota: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            float n2 = float.Parse(Console.ReadLine());

            float media = (n1 + n2) / 2;

            Console.WriteLine($"O aluno {nome}, tirou as notas {n1} e {n2}, e sua média é {media}");
            Console.ReadKey();
        }
    }
}
