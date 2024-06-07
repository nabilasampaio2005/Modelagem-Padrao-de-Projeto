using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodProblema.boletobancario.Caixa
{
    public class BancoCaixaBoleto10Dias : Boleto
    {
        public BancoCaixaBoleto10Dias(double valor)
        {
            this.valor = valor;
            juros = 0.02;
            desconto = 0.1;
            multa = 0.05;
        }

    }
}
