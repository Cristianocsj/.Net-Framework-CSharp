using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[3, 3];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.WriteLine($"Entre com o valor da posição [{i}],[{j}]: ");
                    double valor = double.Parse(Console.ReadLine());
                    mat[i, j] = valor;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("******");
            Console.WriteLine(mat.Length); //Tamanho total da matriz
            Console.WriteLine(mat.Rank); //Quantidade de dimensoes
            Console.WriteLine(mat.GetLength(0)); // Tamanho da dimensão 0
            Console.WriteLine(mat.GetLength(1)); //Tamanho da dimensão 1
        }
    }
}
