﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exeEmpresa.Services;

namespace exeEmpresa.Entities
{
    internal class Contrato
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }
        public List<Parcela> Parcelas { get; set; }

        public Contrato(int numero, DateTime data, double valorTotal)
        {
            Numero = numero;
            Data = data;
            ValorTotal = valorTotal;
            Parcelas = new List<Parcela>();
        }

        public void AdicionarParcela(Parcela parcela)
        {
            Parcelas.Add(parcela);
        }
    }
}
