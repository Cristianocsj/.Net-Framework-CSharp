using av1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace av1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();

            Console.Write("Quantos contribuintes deseja calcular: ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine($"\nDados da #{i + 1}° Pessoa\n");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Renda Anual: ");
                double renda = double.Parse(Console.ReadLine());

                Console.Write("Digite 'F' para pessoa física ou 'J' para pessoa jurídica: ");
                char opc = char.Parse(Console.ReadLine());

                if (opc == 'F' || opc == 'f')
                {
                    Console.Write("Possui gastos com saúde? (S/N): ");
                    opc = char.Parse(Console.ReadLine());
                    if (opc == 'S' || opc == 'S')
                    {
                        Console.Write("Qual valor gasto?: ");
                        double gasto_saude = double.Parse(Console.ReadLine());

                        list.Add(new PFisica(nome, renda, gasto_saude));

                    }
                    else if (opc == 'N' || opc == 'n')
                    {
                        list.Add(new PFisica(nome, renda));
                    }
                }
                else if (opc == 'J' || opc == 'j')
                {
                    Console.Write("Possui quantos funcionarios: ");
                    int n_func = int.Parse(Console.ReadLine());
                    list.Add(new PJuridica(nome, renda, n_func));
                }
            }

            double total_imposto = 0;
            Console.WriteLine("\nTotal de imposto pago:\n");
            foreach (Pessoa pessoa in list)
            {
                //Console.WriteLine($"\nNome: {pessoa.Nome}");
                //Console.WriteLine($"Imposto pago: {pessoa.CalculoImp().ToString("C2")}\n");

                Console.WriteLine(pessoa.Nome + ": " + pessoa.CalculoImp().ToString("C2"));

                total_imposto += pessoa.CalculoImp();
            }

            Console.WriteLine($"\nImposto total dos contribuintes: {total_imposto:C2}");
            Console.ReadLine();
        }
    }
}
