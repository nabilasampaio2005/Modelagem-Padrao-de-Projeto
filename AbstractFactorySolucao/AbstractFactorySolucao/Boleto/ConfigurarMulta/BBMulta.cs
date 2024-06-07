using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySolucao.Boleto.ConfigurarMulta
{
    internal class BBMulta : Multa
    {
        public double getMulta()
        {
            return 0.02;
        }
    }
}
