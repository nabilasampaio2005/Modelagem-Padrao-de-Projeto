using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.GatewayCobranca
{
	public class Gateway
	{
		public Boolean cobrar(double valor)
		{
			bool[] respostas = { true, false };
			Console.WriteLine("Valor Cobrado: R$" + valor);
			return respostas[new Random().Next(0, 1)];
		}
	}
}