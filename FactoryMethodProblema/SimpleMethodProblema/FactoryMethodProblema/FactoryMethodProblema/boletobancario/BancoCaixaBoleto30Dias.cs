using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodProblema.boletobancario
{
    public class BancoCaixaBoleto30Dias : Boleto
    {
        public BancoCaixaBoleto30Dias(double valor)
        {
            this.valor = valor;
            this.juros = 0.05;
            this.desconto = 0.05;
            this.multa = 0.1;
        }
    }
}
