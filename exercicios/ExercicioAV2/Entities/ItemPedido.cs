using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAV2.Entities
{
    class ItemPedido
    {
        public int Quantidade { get; set; }
        public double PrecoI { get; set; }

        public ItemPedido(int quantidade, double precoI)
        {
            Quantidade = quantidade;
            PrecoI = precoI;
        }

        public double SubTotal()
        {
            return Quantidade * PrecoI;
        }
        public override string ToString()
        {
            return $"{Quantidade} x Produto: R${PrecoI}, Subtotal: R${SubTotal()}";
        }
    }
}
