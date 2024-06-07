using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State03.domains.state
{
	public class AguardandoPagamentoState : State
	{
		private Pedido pedido;
		
		public AguardandoPagamentoState(Pedido pedido)
		{
			this.pedido = pedido;
		}

		void State.cancelarPedido()
		{
			this.pedido.estadoAtual = new CanceladoState(pedido);
		}

		void State.despacharPedido()
		{
			throw new Exception("Operação não suportada, pedido ainda não foi pago");
		}

		void State.sucessoAoPagar()
		{
			this.pedido.estadoAtual = new PagoState(pedido);
		}
	}
}
