using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    class ProdutoUsado : Produto
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao) : base(nome, preco)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string EtiquetarPreco()
        {
            return Nome
                + " (usado) $ "
                + Preco.ToString("C2")
                + " (Data Fabricação: "
                + DataFabricacao.ToString("dd/MM/yyyy")
                + ")"; ;
        }
    }
}
