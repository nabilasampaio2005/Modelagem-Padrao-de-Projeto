using DecoratorSolucao.Produto;

Console.WriteLine("Cria uma pizza de queijo");
Pizza pizzaQueijo = new PizzaQueijo();

Console.WriteLine("Produto-> " + pizzaQueijo.getDescricao() + " Valor R$ " + pizzaQueijo.getPreco());

Console.WriteLine(" ");
Console.WriteLine("Adiciona borda de requeijão");
Pizza pizzaQueijoBorda = new BordaRequeijao(pizzaQueijo);

Console.WriteLine("Produto-> " + pizzaQueijoBorda.getDescricao + "Valor R$ " + pizzaQueijoBorda.getPreco());

Console.WriteLine(" ");
Console.WriteLine("Adiciona massa integral");
Pizza pizzaQueijoBordaMassaIntegral = new MassaIntegral(pizzaQueijoBorda);

Console.WriteLine("Produto-> " + pizzaQueijoBordaMassaIntegral.getDescricao + "Valor R$ " + pizzaQueijoBordaMassaIntegral.getPreco());

