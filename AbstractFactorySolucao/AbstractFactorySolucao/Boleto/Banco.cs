using AbstractFactorySolucao.Boleto.Familia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySolucao.Boleto
{
    public class Banco
    {
        public Boleto gerarBoleto(double valor, CalculosFactory factory) 
        { 
            Boleto boleto = new Boleto(valor, factory);

            Console.WriteLine("Boleto gerado com sucesso no valor de R$" + valor);
            Console.WriteLine("Valor Juros R$" + boleto.calcularJuros());
            Console.WriteLine("Valor Multa R$" + boleto.calcularMulta());
            Console.WriteLine("Valor Desconto R$" + boleto.calcularDesconto());
            Console.WriteLine("-------------------------------------------------");

            return boleto;
        }
    }
}
