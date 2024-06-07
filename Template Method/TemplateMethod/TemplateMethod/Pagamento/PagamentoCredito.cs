using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.GatewayCobranca;

namespace TemplateMethod.Pagamento
{
	public class PagamentoCredito
	{
		private double valor { get; set; }
		private Gateway gateway { get; set; }

		public PagamentoCredito(double valor, Gateway gateway)
		{
			this.valor = valor;
			this.gateway = gateway;
		}

		public double calcularTaxa()
		{
			return this.valor * 0.05;
		}

		public double calcularDesconto()
		{
			if (this.valor > 300)
				return this.valor * 0.02;
			else return 0;
		}

		public Boolean realizaCobranca()
		{
			double valorPago = 
				this.valor + this.calcularTaxa()
				-this.calcularDesconto();
			return this.gateway.cobrar(valorPago);
		}
	}
}
