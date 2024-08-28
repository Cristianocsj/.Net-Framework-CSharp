using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex01;

namespace ex01
{
    class Program 
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();

            Console.Write("Entre com o número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Produto #" + i + " Dados:");
                Console.Write("Comum, usado ou importado (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                String nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine());
                if (type == 'c')
                {
                    list.Add(new Produto(nome, preco));
                }
                else if (type == 'u')
                {
                    Console.Write("Data Fabriacação (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    list.Add(new ProdutoUsado(nome, preco, data));
                }
                else
                {
                    list.Add(new ProdutoImportado(nome, preco));
                }
            }

            Console.WriteLine();
            Console.WriteLine("ETIQUETA DE PREÇOS:");
            foreach (Produto prod in list)
            {
                Console.WriteLine(prod.EtiquetarPreco());

            }

            Console.ReadKey();
        }
    }
}
