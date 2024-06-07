using AdapterProblema.Adapter;
using AdapterProblema.Pagamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterProblema.Cobranca
{
    public class Cobranca : Gateway
    {
        public Gateway gateway { get; set; }
        public double valor { get; set; }
        public int parcelas { get; set; }
        public string numeroCartao { get; set; }
        public string cvv {  get; set; }

        public Cobranca() { }

        public void setGateway(Gateway gateway)
        {
            this.gateway = gateway;
            gateway.setValor(valor);
            gateway.setNumeroCartao(numeroCartao);
            gateway.setCVV(cvv);
            gateway.setParcelas(parcelas);
        }

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
            bool valida = false;

            if (gateway.validarCartao() == true)
            {
                Console.WriteLine("Cartão validado com sucesso");
                valida = true;
            } else
            {
                Console.WriteLine("Cartão invalido");
            }
            return valida;
        }

        public bool realizarPagamento()
        {
            bool realiza = false;

            if (gateway.realizarPagamento() == true)
            {
                Console.WriteLine("Aprovado");
                realiza = true;
            } else
            {
                Console.WriteLine("Recusado");
            }
            return realiza;
        }

    }
}
