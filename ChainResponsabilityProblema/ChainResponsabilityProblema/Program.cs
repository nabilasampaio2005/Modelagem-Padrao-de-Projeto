using ChainResponsabilityProblema.CalculadoraPontos;
using ChainResponsabilityProblema.Pedido;

PedidoLanche pedido = new PedidoLanche(21);
CalculadoraPontos calcPontos = new CalculadoraPontos();

Console.Write("Até do dia 15 - Pontos -> ");
Console.WriteLine(calcPontos.calcularPontos(pedido,15));
Console.Write("A partir do dia 16 - Pontos -> ");
Console.WriteLine(calcPontos.calcularPontos(pedido, 16));

pedido.valor = 100;
Console.Write("Até do dia 15 - Pontos -> ");
Console.WriteLine(calcPontos.calcularPontos(pedido, 15));
Console.Write("A partir do dia 16 - Pontos -> ");
Console.WriteLine(calcPontos.calcularPontos(pedido, 16));
