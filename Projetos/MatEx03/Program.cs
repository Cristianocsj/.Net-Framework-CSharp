using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatEx03
{
    internal class Program
    {
        static void Main()
        {
            int[,] matriz;
            int M, N, x;

            LerMatriz(out matriz, out M, out N);
            Console.Write("Digite o valor X: ");
            x = int.Parse(Console.ReadLine());

            bool encontrou = false;

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        encontrou = true;
                        Console.WriteLine($"\nValor {x} encontrado na posição ({i + 1}, {j + 1})");

                        MostrarVizinhos(matriz, i, j, M, N);
                    }
                }
            }

            if (!encontrou)
            {
                Console.WriteLine($"\nValor {x} não encontrado na matriz.");
            }
        }

        static void LerMatriz(out int[,] matriz, out int M, out int N)
        {
            Console.Write("Digite o número de linhas (M): ");
            M = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de colunas (N): ");
            N = int.Parse(Console.ReadLine());

            matriz = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"Digite o valor para a posição ({i + 1}, {j + 1}): ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void MostrarVizinhos(int[,] matriz, int linha, int coluna, int M, int N)
        {
            Console.WriteLine("Vizinhos:");

            if (linha > 0)
            {
                Console.WriteLine($"Acima: {matriz[linha - 1, coluna]}");
            }

            if (coluna > 0)
            {
                Console.WriteLine($"Esquerda: {matriz[linha, coluna - 1]}");
            }

            if (coluna < N - 1)
            {
                Console.WriteLine($"Direita: {matriz[linha, coluna + 1]}");
            }

            if (linha < M - 1)
            {
                Console.WriteLine($"Abaixo: {matriz[linha + 1, coluna]}");
            }
            Console.ReadKey();
        }
    }
}
