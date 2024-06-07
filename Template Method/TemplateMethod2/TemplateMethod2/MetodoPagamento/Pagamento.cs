using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.GatewayCobranca;

namespace TemplateMethod2.MetodoPagamento
{
	public abstract class Pagamento
	{
		protected double valor { get; set; }
		protected Gateway gateway { get; set; }

		public virtual double calcularTaxa()
		{
			return 0;
		}

		public abstract double calcularDesconto();

		public Boolean realizaCobranca()
		{
			double valorPago =
				this.valor + this.calcularTaxa()
				- this.calcularDesconto();
			return this.gateway.cobrar(valorPago);
		}
	}
}
