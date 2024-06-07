using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChainResponsabilityProblema.Pedido;

namespace ChainResponsabilityProblema.CalculadoraPontos
{
    public interface CalculadorDePontos
    {
        public int calcularPontos(PedidoLanche pedido);
        public void setProximo(CalculadorDePontos proximo);
    }
}
