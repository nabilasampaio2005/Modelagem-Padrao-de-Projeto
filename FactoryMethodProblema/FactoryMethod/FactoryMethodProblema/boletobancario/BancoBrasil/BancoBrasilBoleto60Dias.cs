using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodProblema.boletobancario.BancoBrasil
{
    public class BancoBrasilBoleto60Dias : Boleto
    {
            public BancoBrasilBoleto60Dias(double valor)
            {
                this.valor = valor;
                juros = 0.1;
                desconto = 0;
                multa = 0.15;
            }
    }
}
