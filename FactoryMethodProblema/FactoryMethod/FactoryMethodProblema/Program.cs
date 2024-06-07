using FactoryMethodProblema.boletobancario;
using FactoryMethodProblema.boletobancario.BancoBrasil;
using FactoryMethodProblema.boletobancario.Caixa;

Console.WriteLine("-------------------CAIXA-------------------");
Banco bancoCaixa = new BancoCaixa();
bancoCaixa.gerarBoleto(10, 100);
bancoCaixa.gerarBoleto(30, 100);
bancoCaixa.gerarBoleto(60, 100);

Console.WriteLine("-------------------Brasil-------------------");
Banco bancoBrasil = new BancoBrasil();
bancoBrasil.gerarBoleto(10, 100);
bancoBrasil.gerarBoleto(30, 100);
bancoBrasil.gerarBoleto(60, 100);
