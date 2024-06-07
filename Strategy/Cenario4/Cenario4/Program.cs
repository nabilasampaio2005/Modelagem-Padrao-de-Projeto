using Cenario4.Fretes;
using Cenario4.Pedido;

try
{
	Frete freteComum = new FreteComum();
	Frete freteExpresso = new FreteExpresso();

	Pedido pedidoEletro = new PedidoEletronico();
	pedidoEletro.valor = 100;
	pedidoEletro.tipoFrete = freteComum;


	Console.WriteLine("Frete Comum: " + pedidoEletro.nomeSetor + " R$" + pedidoEletro.calculaFrete());


	pedidoEletro.tipoFrete = freteExpresso;

	Console.WriteLine("Frete Expresso: " + pedidoEletro.nomeSetor + " R$" + pedidoEletro.calculaFrete());
}
catch (Exception e)
{
	Console.WriteLine(e.ToString());
}
