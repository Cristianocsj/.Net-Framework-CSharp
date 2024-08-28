using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex02.Classes;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> list = new List<Figura>();

            Console.Write("Entre com o número de figuras: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Figura #{i} Dados:");
                Console.Write("Ratângulo or Circulo (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Cor: ");
                string cor = Console.ReadLine();
                if (ch == 'r')
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine());
                    list.Add(new Retangulo(largura, altura, cor));
                }
                else
                {
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine());
                    list.Add(new Circulo(raio, cor));
                }
            }

            Console.WriteLine();
            Console.WriteLine("AREAS DAS FIGURAS:");
            foreach (Figura figura in list)
            {
                Console.WriteLine(figura.Area().ToString("F2"));
            }

            Console.ReadKey();
        }
    }
}
