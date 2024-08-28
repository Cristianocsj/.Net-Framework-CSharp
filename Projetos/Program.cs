using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioProposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ler o nome do usuário
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();
            //solicitar e ler o sexo do usuário
            Console.WriteLine("Digite o seu sexo (M/F): ");
            char sexo = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();//mover o cursor para a próxima linha
            //solicitar e ler o nome do produto
            Console.WriteLine("Digite o nome do produto: ");
            string prod = Console.ReadLine();
            //ler a quantidade a ser levada
            Console.WriteLine("Digite a quantidade do produto: ");
            int qnt = int.Parse(Console.ReadLine());
            //ler o valor do produto
            Console.WriteLine("Qual é o valor do produto: ");
            double valor = double.Parse(Console.ReadLine());

            //exibir os dados lidos
            Console.WriteLine("\nDados informados:");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Sexo: " + (sexo == 'M' ? "Masculino" : "Feminino"));
            Console.WriteLine("Produto: " + prod);
            Console.WriteLine("Quantidade: " + qnt);
            Console.WriteLine("Valor: R$" + valor.ToString("0.00"));

            Console.ReadKey();
        }
    }
}
