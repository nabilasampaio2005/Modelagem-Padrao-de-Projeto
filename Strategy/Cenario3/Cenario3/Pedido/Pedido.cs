using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cenario3.Pedido
{
    internal abstract class Pedido
    {
        public double valor { get; set; }

        public string? nomeSetor { get; set; }

        public abstract double calculaFreteComum();

        public abstract double calculaFreteExpresso();

    }
}
