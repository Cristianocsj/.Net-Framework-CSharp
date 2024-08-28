using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto
{
    internal class Produto
    {
        private string _nome;
        private double _preco;
        private int _quant;

        public Produto(string nome, double preco, int quant)
        {
            _nome = nome;
            _preco = preco;
            _quant = quant;
        }
        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            { 
                _nome = nome;
            }
        }
        public double GetPreco()
        {
            return _preco;
        }
        public int GetQuant()
        {
            return _quant;
        }

        public double ValorEmEstoque()
        {
            return _preco * _quant;
        }
        public void AdicionarProdutos(int quant)
        {
            _quant = _quant + quant;
        }
        public void RemoverProdutos(int quant)
        {
            _quant = _quant - quant;
        }
    }
}
