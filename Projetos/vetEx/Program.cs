using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho do vetor:");
            int n = int.Parse(Console.ReadLine());
            Produto[] vect = new Produto[n];

            for(int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());
                vect[i] = new Produto { Nome = nome, Preco = preco };
            }

            for(int i = 0;i < n; i++)
            {
                Console.WriteLine(vect[i] + " " + vect[i].Preco.ToString("C2"));
            }

            double sum = 0;
            for(int i = 0;i<n;i++)
            {
                sum += vect[i].Preco;
            }
            double media = sum / n;
            Console.WriteLine("MEDIA = " + media.ToString("F2"));
            Console.ReadKey();
        }
    }
}
