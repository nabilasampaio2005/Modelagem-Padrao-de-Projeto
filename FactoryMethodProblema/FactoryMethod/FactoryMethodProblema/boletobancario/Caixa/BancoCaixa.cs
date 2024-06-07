using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodProblema.boletobancario.Caixa
{
    public class BancoCaixa : Banco
    {
        protected override Boleto criarBoleto(int vencimento, double valor)
        {
            Boleto boleto;
            switch (vencimento)
            {
                case 10:
                    boleto = new BancoCaixaBoleto10Dias(valor);
                    break;
                case 30:
                    boleto = new BancoCaixaBoleto30Dias(valor);
                    break;
                case 60:
                    boleto = new BancoCaixaBoleto60Dias(valor);
                    break;
                default:
                    throw new Exception("Vencimento indisponível");
            }
            return boleto;
        }

    }
}
