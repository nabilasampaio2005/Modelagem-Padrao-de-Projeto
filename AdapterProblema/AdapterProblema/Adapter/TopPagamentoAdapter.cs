using AdapterProblema.Pagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterProblema.Adapter
{
    public class TopPagamentoAdapter : Gateway
    {
        public TopPagamentos topPagamentos;
        public string numeroCartao {  get; set; }
        public string cvv {  get; set; }
        public double valor {  get; set; }
        public int parcelas { get; set; }

        public TopPagamentoAdapter()
        {
            this.topPagamentos = new TopPagamentos();
        }

        public void setCVV(string cvv)
        {
            this.cvv = cvv;
        }

        public void setNumeroCartao(string numeroCartao)
        {
            this.numeroCartao = numeroCartao;
        }

        public void setParcelas(int parcelas)
        {
            this.parcelas = parcelas;
        }

        public void setValor(double valor)
        {
            this.valor = valor;
        }

        public bool validarCartao()
        {
            return true;
        }

        public bool realizarPagamento()
        {
            this.topPagamentos.setValorTotal(this.valor);
            this.topPagamentos.setCartao(this.numeroCartao, this.cvv);
            this.topPagamentos.setQuantidadeParcelas(this.parcelas);

            return this.topPagamentos.realizarPagamento();
        }
    }
}
