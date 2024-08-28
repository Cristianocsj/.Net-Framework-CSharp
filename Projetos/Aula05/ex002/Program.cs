using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            //vetor de 10 posições
            //usuario deve digitar o valor para cada posição
            //média dos vetores

            int [] vet = new int[10];
            int i;
            float soma = 0;
            float media = 0;

            for (i= 0;i< 10; i++)
            {
                Console.WriteLine($"Digite o valor do vetor na posição {i+1}:");
                vet[i] = int.Parse(Console.ReadLine());
                soma += vet[i];
            }

            media = soma / 10;

            //for(i=0; i < 10; i++)
            //{
            //    Console.WriteLine(vet[i]);
            //}
            Console.WriteLine($"A média total dos números digitados é {media}");
            Console.ReadKey();
        }
    }
}
