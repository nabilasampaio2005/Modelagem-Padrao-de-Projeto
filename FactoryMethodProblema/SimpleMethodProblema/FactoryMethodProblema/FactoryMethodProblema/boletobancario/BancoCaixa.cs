using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodProblema.boletobancario
{
    public class BancoCaixa
    {
        private BoletoSimpleFactory boletoSimpleFactory;
        public BancoCaixa(BoletoSimpleFactory boletoSimpleFactory)
        {
            this.boletoSimpleFactory = boletoSimpleFactory;
        }

        public void gerarBoleto(int vencimento, double valor)
        { 
        Boleto boleto = this.boletoSimpleFactory.criarBoleto(vencimento, valor);

            Console.WriteLine("Boleto gerado com sucesso no valor de R$" + valor);
            Console.WriteLine("Valor Juros R$" + boleto.calcularJuros());
            Console.WriteLine("Valor Multa R$" + boleto.calcularMulta());
            Console.WriteLine("Valor Desconto R$" + boleto.calcularDesconto());
            Console.WriteLine("--------------------------------------------------------------");
        }

    }
}
