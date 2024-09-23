using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorSolução.ElementosConcretos
{
   public class Departamento : Elemento
    {
        public string nome { get; set; }

        public List<Produto> produtos { get; set; }

        public Departamento() { }

        public Departamento (string nome)
        {
            this.nome = nome;
            this.produtos = new List<Produto>();
        }

        public void addProduto(Produto produto)
        {
            this.produtos.Add(produto);
        }

        public double aceitar(Visitor.Visitor visitor)
        {
            return visitor.visitDepartamento(this);
        }
    }
}
