using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.GatewayCobranca;

namespace TemplateMethod.Pagamento
{
	public class PagamentoDebito
	{
		private double valor { get; set; }
		private Gateway gateway { get; set; }

		public PagamentoDebito(double valor, Gateway gateway)
		{
			this.valor = valor;
			this.gateway = gateway;
		}

		public double calcularTaxa()
		{
			return 4;
		}

		public double calcularDesconto()
		{
				return this.valor * 0.05;
		}

		public Boolean realizaCobranca()
		{
			double valorPago =
				this.valor + this.calcularTaxa()
				- this.calcularDesconto();
			return this.gateway.cobrar(valorPago);
		}
	}
}
