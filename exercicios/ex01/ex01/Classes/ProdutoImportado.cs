using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex01.Classes;

namespace ex01.Classes
{
    internal class ProdutoImportado : Produto
    {
        public double TaxaTmportacao { get; set; }

        public ProdutoImportado(string nome, double preco):base(nome, preco)
        {
            TaxaTmportacao = preco*0.50;
        }

        public override string EtiquetaPreco()
        {
            return $"{Nome} - R$ {Preco:F2} (Taxa de Importação: {TaxaTmportacao})";
        }

        public double PrecoTotal()
        {
            return Preco * TaxaTmportacao;
        }
    }
}
