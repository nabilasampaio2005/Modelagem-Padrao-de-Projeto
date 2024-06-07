using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State03.domains.state
{
	public class PagoState : State
	{
		private Pedido pedido;

		public PagoState(Pedido pedido) 
		{ 
			this.pedido = pedido;
		}

		void State.cancelarPedido()
		{
			this.pedido.estadoAtual = new CanceladoState(pedido);
		}

		void State.despacharPedido()
		{
			this.pedido.estadoAtual = new EnviadoState(pedido);
		}

		void State.sucessoAoPagar()
		{
			throw new Exception("Operação não suportada, pedido já foi pago");
		}
	}
}
