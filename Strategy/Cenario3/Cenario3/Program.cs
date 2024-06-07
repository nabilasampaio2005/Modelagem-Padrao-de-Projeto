using Cenario3.Pedido;
try
{
    Pedido pedidoE = new PedidoEletronico();
    pedidoE.valor = 100;
    Console.WriteLine("Frete Comum: " + pedidoE.nomeSetor + " R$" + pedidoE.calculaFreteComum());
    Console.WriteLine("Frete Expresso: " + pedidoE.nomeSetor + " R$" + pedidoE.calculaFreteExpresso());

    Pedido pedidoM = new PedidoMoveis();
    pedidoM.valor = 100;
    Console.WriteLine("Frete Comum: " + pedidoM.nomeSetor + " R$" + pedidoM.calculaFreteComum());
    Console.WriteLine("Frete Expresso: " + pedidoM.nomeSetor + " R$" + pedidoM.calculaFreteExpresso());
}
catch (Exception e)
{
    Console.WriteLine(e.ToString());
}