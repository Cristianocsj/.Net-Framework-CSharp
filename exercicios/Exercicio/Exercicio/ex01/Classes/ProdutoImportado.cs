using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    class ProdutoImportado : Produto
    {
        public double TaxaImportacao { get; set; }

        public ProdutoImportado(string nome, double preco) : base(nome, preco)
        {
            TaxaImportacao = Preco * 0.50;
        }

        public double PrecoTotal()
        {
            return Preco + TaxaImportacao;
        }

        public override string EtiquetarPreco()
        {
            return $"{Nome} - {PrecoTotal().ToString("C2")} \t (Taxa de Importação): {TaxaImportacao.ToString("C2")}";
        }
    }
}
