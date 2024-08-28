using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta contaComum1 = new Conta(8510, "Paulo", 100.00);
            ContaJuridica contaPJ = new ContaJuridica(8752, "Maria", 500, 800);
            ContaPoupanca contaPoupanca1 = new ContaPoupanca(2530, "Jamanta", 200, 0.01);

            //Console.WriteLine(contaComum1);
            //Console.WriteLine();

            Console.WriteLine("*****Dados Conta Comum*****");
            Console.WriteLine("Numero da Conta: " + contaComum1.Numero);
            Console.WriteLine("Titular: " + contaComum1.Titular);
            Console.WriteLine("Saldo: " + contaComum1.Saldo);
            Console.WriteLine("Saque de 80.0: ");
            contaComum1.Sacar(80);
            Console.WriteLine("Saldo: " + contaComum1.Saldo);
            Console.ReadKey();
            Console.WriteLine("*****Dados Conta PJ*****");
            Console.WriteLine("Numero da Conta: " + contaPJ.Numero);
            Console.WriteLine("Titular: " + contaPJ.Titular);
            Console.WriteLine("Saldo: " + contaPJ.Saldo);
            Console.WriteLine("Limite de Emprestimo: " + contaPJ.LimiteEmprestimo);
            Console.WriteLine("Saque de 80.0: ");
            contaPJ.Sacar(80);
            Console.WriteLine("Saldo: " + contaPJ.Saldo);
            Console.ReadKey();
            Console.ReadKey();
            Console.WriteLine("*****Dados Conta Pupanca*****");
            Console.WriteLine("Numero da Conta: " + contaPoupanca1.Numero);
            Console.WriteLine("Titular: " + contaPoupanca1.Titular);
            Console.WriteLine("Saldo: " + contaPoupanca1.Saldo);
            Console.WriteLine("Limite de Emprestimo: " + contaPoupanca1.TaxaJuros);
            Console.WriteLine("Saque de 80.0: ");
            contaPoupanca1.Sacar(80);
            Console.WriteLine("Saldo: " + contaPoupanca1.Saldo);
            Console.WriteLine("Atualizando o saldo da conta poupanca");
            contaPoupanca1.AtualizarSaldo(0.01);
            Console.WriteLine("Saldo: " + contaPoupanca1.Saldo);
            Console.ReadKey();

            //Conta conta = new Conta(191004, "Cristiano", 0);
            //ContaJuridica contaPJ = new ContaJuridica(220205, "Banco do Brasil", 0);
            //conta.Titular = "Cristiano";
            //conta.Numero = 220205;
            //conta.Saldo = 0;
            //contaPJ.Titular = "Banco do Brasil";
            //contaPJ.Numero = 191004;
            //contaPJ.Saldo = 0;

            //Console.Write("Valor a ser depositado Conta Comum: ");
            //double valorD = double.Parse(Console.ReadLine());
            //conta.Depositar(valorD);

            //Console.Write("Valor a ser sacado Conta Comum: ");
            //double valorC = double.Parse(Console.ReadLine());
            //conta.Sacar(valorC);

            //Console.WriteLine("Dados da conta: ");
            //Console.WriteLine($"Nome do titular {conta.Titular}");
            //Console.WriteLine($"Número da conta: {conta.Numero}");
            //Console.WriteLine($"Saldo: {conta.Saldo}");

            //Console.WriteLine("Dados da conta jurídica: ");
            //Console.WriteLine($"Nome do titular {contaPJ.Titular}");
            //Console.WriteLine($"Número da conta: {contaPJ.Numero}");
            //Console.WriteLine($"Saldo: {contaPJ.Saldo}");

            //Console.Write("Valor emprestado : ");
            //double valorE = double.Parse(Console.ReadLine());
            //contaPJ.Emprestar(valorE);

            //Console.WriteLine("Dados da conta: ");
            //Console.WriteLine($"Nome do titular {contaPJ.Titular}");
            //Console.WriteLine($"Número da conta: {contaPJ.Numero}");
            //Console.WriteLine($"Saldo: {contaPJ.Saldo}");

            //Console.ReadKey();
        }
    }
}
