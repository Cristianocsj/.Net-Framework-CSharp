using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco =double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            int quant = int.Parse(Console.ReadLine());

            Produto p = new Produto (nome, preco, quant);
            
            Console.WriteLine();
            Console.WriteLine("***");
            Console.WriteLine();

            Console.WriteLine("Dados do produto: ");
            Console.WriteLine("Nome: " + p.GetNome());
            Console.WriteLine($"Preço: {p.GetPreco():C2}");
            Console.WriteLine($"Total: {p.ValorEmEstoque():C2}");
            
            Console.WriteLine();
            Console.WriteLine("***");
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int add = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(add);
            
            Console.WriteLine();
            Console.WriteLine("***");
            Console.WriteLine();

            Console.WriteLine("Dados atualizados do produto: ");
            Console.WriteLine("Nome: " + p.GetNome());
            Console.WriteLine($"Preço: {p.GetPreco():C2}");
            Console.WriteLine($"Total: {p.ValorEmEstoque():C2}");
            
            Console.WriteLine();
            Console.WriteLine("***");
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            add = int.Parse(Console.ReadLine());
            p.RemoverProdutos(add);

            Console.WriteLine("Dados atualizados do produto: ");
            Console.WriteLine("Nome: " + p.GetNome());
            Console.WriteLine($"Preço: {p.GetPreco():C2}");
            Console.WriteLine($"Total: {p.ValorEmEstoque():C2}");
            
            Console.WriteLine();
            Console.WriteLine("***");
            Console.WriteLine();

            Console.WriteLine("Fim");
            Console.ReadKey();
        }
    }
}
