using State02.domains.state;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State02.domains
{
	public class Pedido
	{
		public State aguardandoPagamento { get; set; }
		public State pago { get; set; }
		public State cancelado { get; set; }
		public State enviado { get; set; }
		public State estadoAtual { get; set; }

		public Pedido() {
			Console.WriteLine("Pedido aguardando pagamento");
			this.aguardandoPagamento = new AguardandoPagamentoState(this);
			this.pago = new PagoState(this);
			this.cancelado = new CanceladoState(this);
			this.enviado = new EnviadoState(this);
			this.estadoAtual = this.aguardandoPagamento;
		}

		public void sucessoAoPagar()
		{
			try
			{
				Console.WriteLine("Pedido Pago");
				this.estadoAtual.sucessoAoPagar();
			} 
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		public void cancelarPedido()
		{
			try
			{
				Console.WriteLine("Pedido Cancelado");
				this.estadoAtual.cancelarPedido();
			} 
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		public void despacharPedido()
		{
			try
			{
				Console.WriteLine("Pedido Enviado");
				this.estadoAtual.despacharPedido();
			} catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
