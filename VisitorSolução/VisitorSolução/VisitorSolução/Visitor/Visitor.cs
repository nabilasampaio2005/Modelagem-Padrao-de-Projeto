using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorSolução.ElementosConcretos;

namespace VisitorSolução.Visitor
{
    public interface Visitor
    {
        public double visitSupermercado(Supermercado supermercado);

        public double visitDepartamento(Departamento departamento);

        public double visitProduto(Produto produto);
    }
}
