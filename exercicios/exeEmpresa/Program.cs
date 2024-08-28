using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exeEmpresa.Entities;
using exeEmpresa.Services;

namespace exeEmpresa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados do contrato:");
            Console.Write("Número do contrato: ");
            int numeroContrato = int.Parse(Console.ReadLine());

            Console.Write("Data do contrato (dd/mm/aaaa): ");
            DateTime dataContrato = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Valor total do contrato: R$ ");
            double valorContrato = double.Parse(Console.ReadLine());

            IOnlineServicoPagamento servicoPagamento = new PayPalServico(2.0, 1.0);

            Contrato contrato = new Contrato(numeroContrato, dataContrato, valorContrato);

            ContratoServico contratoServico = new ContratoServico(servicoPagamento);

            Console.Write("Digite o número de meses para parcelamento: ");
            int numeroDeMeses = int.Parse(Console.ReadLine());

            // Processamento do contrato para gerar parcelas
            contratoServico.ProcessarContrato(contrato, numeroDeMeses);

            // Mostra as parcelas geradas na tela
            Console.WriteLine("\nParcelas do Contrato:");
            foreach (var parcela in contrato.Parcelas)
            {
                Console.WriteLine($"Data de Vencimento: {parcela.DataVencimento.ToString("dd/MM/yyyy")} - Valor: R$ {parcela.Valor.ToString("F2")}");
            }
            Console.ReadKey();
        }
    }
}
