using Cenario1.Pedido;

Pedido pedido = new Pedido();

pedido.valor = 100;

Console.WriteLine("Frete Comum:R$" + pedido.calculaFreteComum());

Console.WriteLine("Frete Expresso:R$" + pedido.calculaFreteExpresso());