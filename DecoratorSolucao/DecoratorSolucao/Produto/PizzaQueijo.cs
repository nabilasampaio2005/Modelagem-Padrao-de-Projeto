using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSolucao.Produto
{
    public class PizzaQueijo : Pizza
    {
        public PizzaQueijo()
        {
            this.descricao = "Deliciosa pizza de Queijo";
            this.preco = 22;
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
