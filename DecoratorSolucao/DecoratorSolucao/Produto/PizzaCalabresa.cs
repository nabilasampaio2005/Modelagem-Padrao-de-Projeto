using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSolucao.Produto
{
    public class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa()
        {
            this.descricao = "Deliciosa pizza de Calabresa";
            this.preco = 25;
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
