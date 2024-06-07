using AbstractFactorySolucao.Boleto.ConfigurarDesconto;
using AbstractFactorySolucao.Boleto.ConfigurarJuros;
using AbstractFactorySolucao.Boleto.ConfigurarMulta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySolucao.Boleto.Familia
{
    public interface CalculosFactory
    {
    public Juros criarJuros();
    public Desconto criarDesconto();
    public Multa criarMulta();

    }
}
