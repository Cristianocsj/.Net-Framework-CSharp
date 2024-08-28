using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioDeAula.Classes;

namespace ExercicioDeAula
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo 1

            //ContaComum acc1 = new ContaComum(1001, "Alex", 500.0);
            ContaComum acc2 = new ContaPoupanca(1002, "Anna", 500.0, 0.01);

            //acc1.Saque(10.0);
            acc2.Saque(10.0);

            //Console.WriteLine(acc1.Saldo);
            Console.WriteLine(acc2.Saldo);

            Console.ReadKey();
        }
    }
}
