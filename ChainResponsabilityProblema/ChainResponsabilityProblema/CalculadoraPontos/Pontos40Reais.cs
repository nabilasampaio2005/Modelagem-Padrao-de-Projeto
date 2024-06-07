using ChainResponsabilityProblema.Pedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsabilityProblema.CalculadoraPontos
{
    public class Pontos40Reais : CalculadorDePontos
    {
        private CalculadorDePontos proximoCalculadorDePontos;
        public int calcularPontos(PedidoLanche pedido)
        {
            if (pedido.valor >= 40)
            {
                return (int)(pedido.valor / 7);
            }

            return this.proximoCalculadorDePontos.calcularPontos(pedido);
        }

        public void setProximo(CalculadorDePontos proximo)
        {
            this.proximoCalculadorDePontos = proximo;
        }
    }
}
