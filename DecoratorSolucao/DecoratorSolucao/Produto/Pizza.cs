using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSolucao.Produto
{
    public abstract class Pizza
    {
        protected string descricao {  get; set; }
        protected double preco { get; set; }
        public abstract string getDescricao();
        public abstract double getPreco();
    }
}
