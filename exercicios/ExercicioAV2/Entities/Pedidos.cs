using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAV2.Entities
{
    class Pedido
    {
        public DateTime Data { get; set; }
        public PedidoStatus Status { get; set; }

        public List <ItemPedido> Itens { get; set; } = new List <ItemPedido>();

        public Pedido(DateTime data, PedidoStatus status)
        {
            Data = data;
            Status = status;
        }

        public void AdicionarPedido(ItemPedido itemPedido)
        {
            Itens.Add(itemPedido);
        }
        public void RemoverPedido(ItemPedido itemPedido)
        {
            Itens.Remove(itemPedido);
        }
        public double Total()
        {
            double tot = 0;
            foreach(ItemPedido item in Itens)
                {
                tot += item.SubTotal();
                }
            return tot;
        }
        public override string ToString()
        {
            string resumo = "";
            foreach (ItemPedido item in Itens)
            {
                resumo += item + "\n";
            }
            return resumo;
        }
    }
}
