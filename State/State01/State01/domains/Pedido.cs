using State01.domains.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State01.domains
{
	public class Pedido
	{
		private StatusPedido statusPedido {  get; set; }

		public Pedido() {
			Console.WriteLine("Pedido aguardando pagamento");
			this.statusPedido = StatusPedido.Aguardando_Pagamento;
		}

		public void sucessoAoPagar()
		{
			if(this.statusPedido == StatusPedido.Aguardando_Pagamento)
			{
				Console.WriteLine("Pedido Pago");
				this.statusPedido = StatusPedido.Pago;
			}
			else
			{
				throw new Exception("O pedido não está aguardando pagamento");
			}
		}

		public void cancelarPedido() 
		{ 
			if(this.statusPedido == StatusPedido.Pago || this.statusPedido == StatusPedido.Aguardando_Pagamento)
			{
				Console.WriteLine("Pedido Cancelado");
				this.statusPedido = StatusPedido.Cancelado;
			}
			else
			{
				throw new Exception("O pedido se encontra "+this.statusPedido.ToString());
			}
		}

		public void despacharPedido()
		{
			if(this.statusPedido == StatusPedido.Pago)
			{
				Console.WriteLine("Pedido Enviado");
				this.statusPedido= StatusPedido.Enviado;
			} 
			else
			{
				throw new Exception("O pedido se encontra cancelado");
			}
		}
	}
}
