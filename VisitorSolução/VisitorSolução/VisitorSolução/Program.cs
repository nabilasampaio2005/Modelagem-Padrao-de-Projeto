using System.Security.AccessControl;
using System.Threading.Channels;
using VisitorSolução.ElementosConcretos;
using VisitorSolução.Visitor;

Supermercado supermercado = new Supermercado(nome: "Supermercado da Esquina");

Departamento departamento01 = new Departamento(nome: "Alimentação básica");
Produto arroz = new Produto(nome: "Arroz 5kg", preco: 18, margemLucro: 30);
Produto macarrao = new Produto(nome: "Macarrão", preco: 3.20, margemLucro: 15);

departamento01.addProduto(arroz);
departamento01.addProduto(macarrao);

Departamento departamento02 = new Departamento(nome: "Higiene");
Produto papelHigienico = new Produto(nome: "Papel Higiênico", preco: 11, margemLucro: 35);
Produto sabonete = new Produto(nome: "Sabonete", preco: 1.2, margemLucro: 10);

departamento02.addProduto(papelHigienico);
departamento02.addProduto(sabonete);

supermercado.addDepartamento(departamento01);
supermercado.addDepartamento(departamento02);

//calcula lucratividade
Lucratividade visitorLucratividade = new Lucratividade();

//passagem do visitante pelo método aceitar() do supermercado, departamentos e produtos
Console.WriteLine($"----- Margem Produtos - {departamento01.nome} -----");
Console.WriteLine($"Produto: {arroz.nome} - lucro: {arroz.aceitar(visitorLucratividade)}");
Console.WriteLine($"Produto: {macarrao.nome} - lucro: {macarrao.aceitar(visitorLucratividade)}");

Console.WriteLine($"----- Margem Lucro do {departamento01.nome} -----");
Console.WriteLine($"Lucro do Departamento: {departamento01.aceitar(visitorLucratividade)}");

Console.WriteLine($"----- Margem Produtos - {departamento02.nome} -----");
Console.WriteLine($"Produto: {papelHigienico.nome} - lucro: {papelHigienico.aceitar(visitorLucratividade)}");
Console.WriteLine($"Produto: {sabonete.nome} - lucro: {sabonete.aceitar(visitorLucratividade)}");

Console.WriteLine($"----- Margem Lucro do {departamento02.nome} -----");
Console.WriteLine($"Lucro do Departamento: {departamento02.aceitar(visitorLucratividade)}");

Console.WriteLine($"----- Margem Lucro do supermercado {supermercado.nome} -----");
Console.WriteLine($"Lucro do Supermercado: {supermercado.aceitar(visitorLucratividade)}");
