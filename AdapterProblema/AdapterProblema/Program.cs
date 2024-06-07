// See https://aka.ms/new-console-template for more information
using AdapterProblema.Adapter;
using AdapterProblema.Cobranca;
using AdapterProblema.Pagamento;

Console.WriteLine("Configura a Cobranca");

Cobranca cobranca = new Cobranca();
cobranca.setValor(100);
cobranca.setNumeroCartao("999999999999");
cobranca.setCVV("163");

//teste pagFacil
cobranca.setGateway(new PagFacilAdapter());
cobranca.validarCartao();
cobranca.realizarPagamento();

//teste TopPag
cobranca.setGateway(new TopPagamentoAdapter());
cobranca.validarCartao();
cobranca.realizarPagamento();


