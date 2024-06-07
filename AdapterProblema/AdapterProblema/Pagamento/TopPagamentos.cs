using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterProblema.Pagamento
{
    public class TopPagamentos
    {

        const double taxaPagamento = 5;
        const double juroMensal = 0.1;

        public double valorTotal { get; set; }
        public int quantidadeParcelas { get; set; }
        public string numeroCartao { get; set; }
        public string cvv { get; set; }

        public void setValorTotal(double valorTotal)
        {
            this.valorTotal = valorTotal;
        }

        public void setQuantidadeParcelas(int quantidadeParcelas)
        {
            this.quantidadeParcelas = quantidadeParcelas;
        }

        public void setCartao(string cartao, string cvv)
        {
            this.cvv = cvv;
            this.numeroCartao = cartao;
        }

        public bool realizarPagamento()
        {
            return true;
        }

    }
}
