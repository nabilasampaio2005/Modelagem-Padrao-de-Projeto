using Cenario2.Pedido;

Pedido pedidoE = new PedidoEletronico();

pedidoE.valor = 100;

Console.WriteLine("Frete Comum: " + pedidoE.nomeSetor + " R$" + pedidoE.calculaFreteComum());

Console.WriteLine("Frete Expresso: " + pedidoE.nomeSetor+" R$" + pedidoE.calculaFreteExpresso());