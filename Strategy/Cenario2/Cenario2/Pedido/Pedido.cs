using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cenario2.Pedido
{
    internal class Pedido
    {
        public double valor { get; set; }

        public string? nomeSetor { get; set; }

        public double calculaFreteComum()
        {
            return this.valor * 0.05;
        }

        public double calculaFreteExpresso()
        {
            return this.valor * 0.1;
        }

    }
}
