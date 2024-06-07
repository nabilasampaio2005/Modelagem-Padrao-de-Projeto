using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodProblema.boletobancario
{
    public class BancoCaixaBoleto60Dias: Boleto
    {
        public BancoCaixaBoleto60Dias(double valor)
        {
            this.valor = valor;
            this.juros = 0.1;
            this.desconto = 0;
            this.multa = 0.2;
        }
    }
}
