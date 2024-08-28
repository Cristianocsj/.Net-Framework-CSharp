using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAV2.Entities
{
    enum PedidoStatus:int
    {
        Pendente = 0,
        Processando = 1,
        Enviado = 2,
        Entregue = 3
    }
}
