using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodProblema.boletobancario.BancoBrasil
{
    public class BancoBrasil : Banco
    {
            protected override Boleto criarBoleto(int vencimento, double valor)
            {
                Boleto boleto;
                switch (vencimento)
                {
                    case 10:
                        boleto = new BancoBrasilBoleto10Dias(valor);
                        break;
                    case 30:
                        boleto = new BancoBrasilBoleto30Dias(valor);
                        break;
                    case 60:
                        boleto = new BancoBrasilBoleto60Dias(valor);
                        break;
                    default:
                        throw new Exception("Vencimento indisponível");
                }
                return boleto;
            }

        
    }
}
