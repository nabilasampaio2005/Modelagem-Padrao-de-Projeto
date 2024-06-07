using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodProblema.boletobancario
{
    public abstract class Banco
    {
        protected abstract Boleto criarBoleto(int vencimento, double valor);

        public void gerarBoleto(int vencimento, double valor)
        {
            Boleto boleto = this.criarBoleto(vencimento, valor);

            Console.WriteLine("Boleto gerado com sucesso no valor de R$" + valor);
            Console.WriteLine("Valor Juros R$" + boleto.calcularJuros());
            Console.WriteLine("Valor Multa R$" + boleto.calcularMulta());
            Console.WriteLine("Valor Desconto R$" + boleto.calcularDesconto());
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
