using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeProblema.vendas
{
    public class PagamentoCredito : Pagamento
    {
        public PagamentoCredito(Pedido pedido) {
            this.pedido = pedido;
        }
        public override bool realizarPagamento()
        {
            return true;
        }
    }
}
