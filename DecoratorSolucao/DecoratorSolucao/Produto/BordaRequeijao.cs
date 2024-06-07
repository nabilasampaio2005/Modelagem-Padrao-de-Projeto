using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSolucao.Produto
{
    public class BordaRequeijao : AcrescimoDecorator
    {
        private double valorBorda = 8.5;

        public BordaRequeijao(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override string getDescricao()
        {
            return this.pizza.getDescricao() + "Borda recheada de requeijão";
        }

        public override double getPreco()
        {
            return this.pizza.getPreco()+valorBorda;
        }
    }
}
