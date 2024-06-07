using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodProblema.boletobancario.BancoBrasil
{
    public class BancoBrasilBoleto10Dias : Boleto
    {
        public BancoBrasilBoleto10Dias(double valor) 
        { 
            this.valor = valor;
            juros = 0.03;
            desconto = 0.05;
            multa = 0.02;
        }
    }
}
