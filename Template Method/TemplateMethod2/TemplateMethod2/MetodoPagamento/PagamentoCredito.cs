using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.GatewayCobranca;
using TemplateMethod2.MetodoPagamento;

namespace TemplateMethod.MetodoPagamento
{
	public class PagamentoCredito : Pagamento
	{
		public PagamentoCredito(double valor, Gateway gateway)
		{
			this.valor = valor;
			this.gateway = gateway;
		}

		public override double calcularTaxa()
		{
			return this.valor * 0.05;
		}

		public override double calcularDesconto()
		{
			if (this.valor > 300)
				return this.valor * 0.02;
			else return 0;
		}
	}
}
