using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrecaoEmp.Entities
{
    internal class Contrato
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }

        public List<Parcela> Parcela { get; set; }

        public Contrato(int numero, DateTime data, double valorTotal)
        {
            Numero = numero;
            Data = data;
            ValorTotal = valorTotal;
            Parcela = new List<Parcela>();
        }

        public void AdicionarParcela(Parcela parcela)
        {
            Parcela.Add(parcela);
        }
    }
}
