using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySolucao.Boleto.ConfigurarDesconto
{
    internal class CaixaDesconto : Desconto
    {
        public double getDesconto()
        {
            return 0.1;
        }
    }
}
