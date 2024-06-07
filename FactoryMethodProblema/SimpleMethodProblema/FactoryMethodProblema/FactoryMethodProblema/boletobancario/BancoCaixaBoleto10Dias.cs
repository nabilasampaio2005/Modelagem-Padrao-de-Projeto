using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodProblema.boletobancario
{
    public class BancoCaixaBoleto10Dias: Boleto
    {
        public BancoCaixaBoleto10Dias(double valor)
        {
            this.valor = valor;
            this.juros = 0.02;
            this.desconto = 0.1;
            this.multa = 0.05;
        }
        
    }
}
