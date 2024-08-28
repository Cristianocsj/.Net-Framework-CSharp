using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioAV2.Entities;

namespace ExercicioAV2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Dados do Cliente:");

                Console.Write("Nome: ");
                string nomeC = Console.ReadLine();

                Console.Write("E-mail: ");
                string email = Console.ReadLine();

                Console.Write("Data de Nascimento (DD/MM/AAAA): ");
                DateTime nascimento = DateTime.Parse(Console.ReadLine());
                Cliente cliente = new Cliente(nomeC, email, nascimento);

                Console.WriteLine("Dados do Pedido: ");
                DateTime dataP = DateTime.Now;

                Console.Write("Status: ");
                PedidoStatus status = (PedidoStatus)Enum.Parse(typeof(PedidoStatus), Console.ReadLine());

                Console.Write("Quantos Itens tem o pedido? ");
                int qtdItens = int.Parse(Console.ReadLine());

                Pedido pedido = new Pedido(dataP, status);

                for (int i = 0; i < qtdItens; i++)
                {
                    Console.WriteLine($"Item #{i + 1}:");

                    Console.Write("Nome do Produto: ");
                    string nomeP = Console.ReadLine();

                    Console.Write("Preço do Produto: ");
                    double precoP = double.Parse(Console.ReadLine());

                    Console.Write("Quantidade: ");
                    int qtd = int.Parse(Console.ReadLine());

                    Produto produto = new Produto(nomeP, precoP);
                    ItemPedido itemPedido = new ItemPedido(qtd, precoP);

                    pedido.AdicionarPedido(itemPedido);
                }
                Console.WriteLine();

                Console.WriteLine("RESUMO DO PEDIDO:");
                Console.WriteLine("Data do Pedido: " + dataP.ToString("dd/MM/yyyy HH:mm:ss"));
                Console.WriteLine("Status: " + status);
                Console.WriteLine($"Cliente: {cliente.NomeC}, {cliente.Nascimento} - {cliente.Email}");
                Console.WriteLine();

                Console.WriteLine("RESUMO DOS ITENS: ");
                Console.WriteLine($"{pedido}");
                Console.WriteLine($"Total do Pedido: {pedido.Total()}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
