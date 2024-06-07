using AbstractFactorySolucao.Boleto.ConfigurarDesconto;
using AbstractFactorySolucao.Boleto.ConfigurarJuros;
using AbstractFactorySolucao.Boleto.ConfigurarMulta;
using AbstractFactorySolucao.Boleto.Familia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySolucao.Boleto
{
    public class Boleto
    {
        protected double valor;
        protected Juros juros;
        protected Desconto desconto;
        protected Multa multa;

        public Boleto(double valor, CalculosFactory factory)
        {
            this.valor = valor;
            this.juros = factory.criarJuros();
            this.desconto = factory.criarDesconto();
            this.multa = factory.criarMulta();
        }

        public double calcularJuros()
        {
            return this.valor * this.juros.getJuros();
        }

        public double calcularDesconto()
        {
            return this.valor * this.desconto.getDesconto();
        }

        public double calcularMulta()
        {
            return this.valor * this.multa.getMulta();
        }
    }
}
