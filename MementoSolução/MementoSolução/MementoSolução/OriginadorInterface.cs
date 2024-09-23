using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoSolução
{
    public interface OriginadorInterface
    {
        public MementoInterface salvar();
        public void imprimir();
    }
}
