using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodProblema.boletobancario.BancoBrasil
{
    public class BancoBrasilBoleto30Dias : Boleto
    {
        public BancoBrasilBoleto30Dias(double valor)
        {
            this.valor = valor;
            juros = 0.05;
            desconto = 0.02;
            multa = 0.05;
        }
    }
}
