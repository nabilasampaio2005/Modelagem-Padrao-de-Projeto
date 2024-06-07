using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSolucao.Produto
{
    public class PizzaFrango : Pizza
    {
        public PizzaFrango()
        {
            this.descricao = "Deliciosa pizza de Frango";
            this.preco = 19;
        }
        public override string getDescricao()
        {
            return this.descricao;
        }

        public override double getPreco()
        {
            return this.preco;
        }
    }
}
