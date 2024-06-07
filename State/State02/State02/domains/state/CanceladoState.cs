using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State02.domains.state
{
	public class CanceladoState : State
	{
		private Pedido pedido;

		public CanceladoState(Pedido pedido)
		{
			this.pedido = pedido;
		}

		void State.cancelarPedido()
		{
			throw new Exception("Operação não suportada, pedido foi cancelado");
		}

		void State.despacharPedido() {
			throw new Exception("Operação não suportada, pedido foi cancelado");
		}

		void State.sucessoAoPagar()
		{
			throw new Exception("Operação não suportada, pedido foi cancelado");
		}
	}
}
