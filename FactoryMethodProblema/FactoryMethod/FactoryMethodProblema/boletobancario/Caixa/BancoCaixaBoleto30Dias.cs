using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodProblema.boletobancario.Caixa
{
    public class BancoCaixaBoleto30Dias : Boleto
    {
        public BancoCaixaBoleto30Dias(double valor)
        {
            this.valor = valor;
            juros = 0.05;
            desconto = 0.05;
            multa = 0.1;
        }
    }
}
