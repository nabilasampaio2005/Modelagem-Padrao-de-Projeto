using ChainResponsabilityProblema.Pedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsabilityProblema.CalculadoraPontos
{
    public class CalculadoraPontos
    {
        public int calcularPontos(PedidoLanche pedido, int dia)
        {
            CalculadorDePontos pontos70 = new Pontos70Reais();
            CalculadorDePontos pontos40 = new Pontos40Reais();
            CalculadorDePontos pontos20 = new Pontos20Reais();
            CalculadorDePontos nenhumPonto = new NenhumPonto();

            pontos70.setProximo(pontos40);
            pontos40.setProximo(pontos20);
            pontos20.setProximo(nenhumPonto);

            if (dia >= 16 && dia <= 31)
            {
                return pontos70.calcularPontos(pedido) * 2;
            }

            return pontos70.calcularPontos(pedido);
        }
    }
}
