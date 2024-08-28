using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioArquivos
    {
        class Program
        {
            static void Main(string[] args)
            {
                string outputDir = @"C:\Junior\faculdade\quarto-periodo\LP3\PastaSaida";
                string inputFile = @"C:\Junior\faculdade\quarto-periodo\LP3\Produtos.txt";
                string outputFile = Path.Combine(outputDir, "Nota.txt");
                Directory.CreateDirectory(outputDir);
                try
                {
                    string[] lines = File.ReadAllLines(inputFile);
                    var itens = new List<(string Nome, double ValorTotal)>();
                    foreach (string line in lines)
                    {
                        string[] partes = line.Split(';');
                        if (partes.Length == 3)
                        {
                            string nome = partes[0];
                            try
                            {
                                double preco = double.Parse(partes[1]);
                                double qtd = double.Parse(partes[2]);
                                double valorTotal = preco * qtd;
                                itens.Add((nome, valorTotal));
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine($"Erro ao processar a linha: {line}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Linha mal formatada: {line}");
                        }
                    }
                    using (StreamWriter writer = new StreamWriter(outputFile))
                    {
                        foreach (var item in itens)
                        {
                            writer.WriteLine($"{item.Nome};{item.ValorTotal}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                }
                Console.ReadKey();
            }
        }
    }
