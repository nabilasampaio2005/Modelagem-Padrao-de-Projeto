using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsabilityProblema.Pedido
{
    public class PedidoLanche
    {
        public double valor { get; set; }

        public PedidoLanche(double valor)
        {
            this.valor = valor;
        }
    }
}
