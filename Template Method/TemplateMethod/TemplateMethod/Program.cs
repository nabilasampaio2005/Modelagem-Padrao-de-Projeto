using TemplateMethod.GatewayCobranca;
using TemplateMethod.Pagamento;

double valor = 100;
Gateway gataway = new Gateway();

Console.WriteLine("Crédito");
PagamentoCredito pgCred = new PagamentoCredito(valor, gataway);
pgCred.realizaCobranca();
Console.WriteLine("Debito");
PagamentoDebito pgDeb = new PagamentoDebito(valor, gataway);
pgDeb.realizaCobranca();
Console.WriteLine("Dinheiro");
PagamentoDinheiro pgDin = new PagamentoDinheiro(valor, gataway);
pgDin.realizaCobranca();