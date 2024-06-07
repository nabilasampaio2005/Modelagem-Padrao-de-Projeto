using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cenario3.Pedido
{
    internal class PedidoEletronico:Pedido
    {
     public PedidoEletronico()
        {
            this.nomeSetor = "Eletronicos";
        }
        public override double calculaFreteExpresso()
        {
            return this.valor * 0.1;
        }

        public override double calculaFreteComum()
        {
            return this.valor * 0.05;
        }

    }
}
