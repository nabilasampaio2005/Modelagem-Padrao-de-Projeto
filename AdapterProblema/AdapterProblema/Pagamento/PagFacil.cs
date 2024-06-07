
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterProblema.Pagamento
{
    public class PagFacil
    {
        const double taxaPagamento = 0.4;
        const double juroMensal = 0.5;

        public double valor { get; set; }
        public int parcelas { get; set; }
        public string numeroCartao { get; set; }
        public string cvv { get; set; }
        
        public void setValor(double valor)
        {
            this.valor = valor;
        }

        public void setParcelas(int parcelas)
        {
            this.parcelas = parcelas;
        }

        public void setNumeroCartao(string numeroCartao)
        {
            this.numeroCartao = numeroCartao;
        }

        public void setCVV(string cvv)
        {
            this.cvv = cvv;
        }

        public bool validarCartao()
        {
            return true;
        }

        public bool realizarPagamento()
        {
            return true;
        }
    }
}
