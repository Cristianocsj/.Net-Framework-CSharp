﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex004
{
    class Program
    {
        static void Main(string[] args)
        {
           string nome ;

            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("O nome digitado foi " + nome + ". Bem vindo!");
            Console.ReadLine();
        }
    }
}
