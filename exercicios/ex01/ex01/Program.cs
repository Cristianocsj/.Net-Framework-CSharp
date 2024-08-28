using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex01.Classes;
using ex01.Classes.EtiquetaPrecoProdutos;

namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco = 0;
            string nome;

            Produto produto = new Produto();

            List<Produto> list = new List<Produto>();

            Console.Write("Entre com o número de produtos: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Produto #{i+1} Dados:");
                Console.Write("Comum, usado ou importado (c/u/i)?");
                char tipo = char.Parse(Console.ReadLine());
                
                if (tipo == 'c')
                {
                    Console.Write($"Nome do produto #{i}: ");
                    nome = Console.ReadLine();
                    Console.Write($"Preço do produto #{i}: ");
                    preco = double.Parse(Console.ReadLine());
                    list.Add(new Produto(nome, preco));
                } else if (tipo ==  'u')
                {
                    Console.Write($"Nome do produto #{i}: ");
                    nome = Console.ReadLine();
                    Console.Write($"Preço do produto #{i}: ");
                    preco = double.Parse(Console.ReadLine());
                    list.Add(new ProdutoImportado(nome, preco));
                }
                else
                {
                    Console.Write($"Nome do produto #{i}: ");
                    nome = Console.ReadLine();
                    Console.Write($"Preço do produto #{i}: ");
                    preco = double.Parse(Console.ReadLine());
                    Console.Write("Data de fabricação (DD/MM/YYYY): ");
                    DateTime datafabricacao = DateTime.Parse(Console.ReadLine());
                    list.Add(new ProdutoUsado(nome, preco, datafabricacao));
                }

                Console.WriteLine("\nETIQUETA DE PREÇOS: ");

                foreach (Produto produto in list) ;



            }
        }
    }
}
