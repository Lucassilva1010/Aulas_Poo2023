using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPedidos.Enums
{
    enum StatusPedido: int
    {
        Pendente = 1,
        Processando = 2,
        Enviado = 3,
        Entregue = 4
    }
}
