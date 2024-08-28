using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioBoleto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************");

            Console.Write("Cedente: ");
            string ced = Console.ReadLine();

            Console.Write("Descrição do Serviço: ");
            string desc = Console.ReadLine();

            Console.Write("Valor do Serviço: ");
            double valServico = double.Parse(Console.ReadLine());

            Console.Write("Data de Emissão: ");
            DateTime dataEmissao = DateTime.Parse(Console.ReadLine());

            Console.Write("Data de Vencimento: ");
            DateTime dataVencimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("********************");

            Console.Write("Digite a data do pagamento: ");
            DateTime dataPagamento = DateTime.Parse(Console.ReadLine());

            double total = 0;
            Boleto boleto = new Boleto(ced, desc, valServico, dataEmissao, dataVencimento, dataPagamento, total);
            var resultado = boleto.CalcularPagamento();
            total = resultado.Item1;
            TimeSpan dias = resultado.Item2;

            Console.WriteLine($"Valor a pagar: {total:C2}");
            if(dataPagamento > dataVencimento)
            {
                Console.WriteLine($"O boleto foi pago com {dias.Days} de atraso");
            }
            Console.ReadKey();
        }
    }
}
