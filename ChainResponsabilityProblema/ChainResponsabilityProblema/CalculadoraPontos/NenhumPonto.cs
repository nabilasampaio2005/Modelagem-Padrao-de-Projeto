using ChainResponsabilityProblema.Pedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsabilityProblema.CalculadoraPontos
{
    public class NenhumPonto : CalculadorDePontos
    {
        public int calcularPontos(PedidoLanche pedido)
        {
            return 0;
        }

        public void setProximo(CalculadorDePontos proximo)
        {
            //fim da cadeia
        }
    }
}
