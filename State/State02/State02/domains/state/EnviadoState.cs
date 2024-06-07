using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State02.domains.state
{
	public class EnviadoState : State
	{
		private Pedido pedido;

		public EnviadoState(Pedido pedido)
		{
			this.pedido = pedido;
		}

		void State.cancelarPedido()
		{
			throw new Exception("Operação não suportada, pedido já foi enviado");
		}

		void State.despacharPedido()
		{
			throw new Exception("Operação não suportada, pedido já foi enviado");
		}

		void State.sucessoAoPagar()
		{
			throw new Exception("Operação não suportada, pedido já foi enviado");
		}
	}
}
