using State01.domains;

try
{

	Console.WriteLine("---------- Pedido 01 ----------");
	Pedido pedido = new Pedido();
	pedido.sucessoAoPagar();
	pedido.despacharPedido();

	Console.WriteLine("---------- Pedido 02 ----------");
	Pedido pedido2 = new Pedido();
	pedido2.sucessoAoPagar();
	pedido2.despacharPedido();
	pedido2.cancelarPedido();

} catch (Exception e)
{
	Console.WriteLine(e.Message);
}
