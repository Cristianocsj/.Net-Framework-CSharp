using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex01.Classes;

namespace ex01.Classes
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Preco = preco;
            Nome = nome;
        }

        public virtual string EtiquetaPreco()
        {
            return $"{Nome} - R$ {Preco:F2}";
        }
    }
}
