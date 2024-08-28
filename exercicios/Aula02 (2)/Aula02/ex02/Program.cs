using ex02.Classes;
using ex02.NovaPasta;

Console.WriteLine("***Conta Comum***");
Conta contaComum1 = new Conta(8510, "Paulo", 100.00);
Console.WriteLine(contaComum1);

Console.WriteLine("***Conta Juridica**");
ContaPJ contaPJ = new ContaPJ(8752, "Maria", 500, 800);
Console.WriteLine(contaPJ);

Console.WriteLine("***Conta Poupança**");
ContaPoupanca contaPoupanca1 = new ContaPoupanca(2530, "Jamanta", 200, 0.01);
Console.WriteLine(contaPoupanca1);
Console.ReadKey();