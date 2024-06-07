using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorSolucao.IteratorModel
{
    public interface Iterator
    {
        public Boolean hasNext();
        public int next();
    }
}
