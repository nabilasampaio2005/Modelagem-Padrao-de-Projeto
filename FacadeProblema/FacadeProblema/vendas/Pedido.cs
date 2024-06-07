using FacadeProblema.cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeProblema.vendas
{
    public class Pedido
    {
        public Consumidor consumidor { get; set; }
        public List<Produto> produtos = new List<Produto>();

        public void addProduto(Produto produto)
        {
            this.produtos.Add(produto);
        }
    }
}
