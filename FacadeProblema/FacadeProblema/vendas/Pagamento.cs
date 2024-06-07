using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeProblema.vendas
{
    public abstract class Pagamento
    {
        protected Pedido pedido;

        public abstract Boolean realizarPagamento();

    }
}
