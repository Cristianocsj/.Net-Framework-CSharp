using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CorrecaoEmp.Entities;
using CorrecaoEmp.Entities;
using CorrecaoEmp.Services;

namespace CorrecaoEmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do contráto:");

            Console.Write("Número: ");
            int numContrato = int.Parse(Console.ReadLine());

            Console.Write("Data: ");
            DateTime dataContrato = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Valor do contráto: ");
            double valorContrato = double.Parse(Console.ReadLine());

            Console.Write("Número de prestações: ");
            int meses = int.Parse(Console.ReadLine());

            Contrato meuContrato = new Contrato(numContrato, dataContrato, valorContrato);
            //Serviço do contráto
            ContratoServico contratoServico = new ContratoServico(new PayPalService());
            contratoServico.ProcessarContrato(meuContrato, meses);

            Console.WriteLine("Parcelas: ");
            foreach (Parcela parcela in meuContrato.Parcela)
            {
                Console.WriteLine(parcela);
            }

            Console.ReadLine();
        }
    }
}
