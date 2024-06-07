using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySolucao.Boleto.ConfigurarDesconto
{
    internal class BBDesconto : Desconto
    {
        public double getDesconto()
        {
            return 0.05;
        }
    }
}
