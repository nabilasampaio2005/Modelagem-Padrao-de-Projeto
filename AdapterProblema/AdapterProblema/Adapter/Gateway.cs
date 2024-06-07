using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterProblema.Adapter
{
    public interface Gateway
    {
        public void setValor(double valor);
        public void setParcelas(int parcelas);
        public void setNumeroCartao(string numeroCartao);
        public void setCVV(string cvv);
        public bool validarCartao();
        public bool realizarPagamento();
    }
}
