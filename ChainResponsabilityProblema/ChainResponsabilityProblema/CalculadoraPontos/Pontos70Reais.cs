using ChainResponsabilityProblema.Pedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsabilityProblema.CalculadoraPontos
{
    public class Pontos70Reais : CalculadorDePontos
    {
        private CalculadorDePontos proximoCalculadorDePontos;
        public int calcularPontos(PedidoLanche pedido)
        {
            if (pedido.valor >= 70)
            {
                return (int)(pedido.valor / 5);
            }

            return this.proximoCalculadorDePontos.calcularPontos(pedido);
        }

        public void setProximo(CalculadorDePontos proximo)
        {
            this.proximoCalculadorDePontos = proximo;
        }
    }
}
