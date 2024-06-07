using FacadeProblema.cadastros;
using FacadeProblema.facade;
using FacadeProblema.vendas;

Consumidor consumidor = new Consumidor("Consumidor01", "0101010101", "consum@gmail.com");

Produto produto1 = new Produto("Blusa", "Blusa feminina", 80);
Produto produto2 = new Produto("Camiseta", "Camiseta Masculina", 45);
Produto produto3 = new Produto("Calça Jeans", "Calça Jeans Masculina", 120);

FacadeVendas pedido = new FacadeVendas(consumidor);
pedido.addProduto(produto1);
pedido.addProduto(produto2);
pedido.addProduto(produto3);

pedido.pedidoBoleto();