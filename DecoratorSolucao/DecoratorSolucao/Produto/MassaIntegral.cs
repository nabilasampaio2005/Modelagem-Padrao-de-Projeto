using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSolucao.Produto
{
    public class MassaIntegral : AcrescimoDecorator
    {
        private double valorMassaIntegral = 5;

        public MassaIntegral(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override string getDescricao()
        {
            return this.pizza.getDescricao() + "Massa Integral";
        }

        public override double getPreco()
        {
            return this.pizza.getPreco() + valorMassaIntegral;
        }
    }
}
