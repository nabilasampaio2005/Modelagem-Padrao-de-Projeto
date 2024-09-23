using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorSolução.Visitor;

namespace VisitorSolução.ElementosConcretos
{
   public interface Elemento
    {
        public double aceitar(Visitor.Visitor visitor);
    }
}
