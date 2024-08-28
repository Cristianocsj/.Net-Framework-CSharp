using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex01.Classes;

namespace ex01.Classes
{
    using System;

    namespace EtiquetaPrecoProdutos
    {
        class ProdutoUsado : Produto
        {
            public DateTime DataFabricacao { get; set; }

            public ProdutoUsado(string nome, double preco, DateTime dataFabricacao) : base(nome, preco)
            {
                DataFabricacao = dataFabricacao;
            }

            public override string EtiquetaPreco()
            {
                return $"{Nome} (usado) - R$ {Preco:F2} (Fabricado em {DataFabricacao:dd/MM/yyyy})";
            }

        }
    }
}


