using AbstractFactorySolucao.Boleto;
using AbstractFactorySolucao.Boleto.Familia;
using System;

Banco banco = new Banco();
CalculosFactory factoryCaixa = new CaixaCalculosFactory();
CalculosFactory factoryBB = new BBCalculosFactory();

Console.WriteLine("cria boleto caixa");
banco.gerarBoleto(100, factoryCaixa);

Console.WriteLine("cria boleto BB");
banco.gerarBoleto(100, factoryBB);
