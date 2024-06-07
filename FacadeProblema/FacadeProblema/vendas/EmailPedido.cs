using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeProblema.vendas
{
    public class EmailPedido
    {
        private Pedido pedido;

        public EmailPedido(Pedido pedido) {
            this.pedido = pedido;
        }

        public void enviarEmail(String mensagem)
        {
            Console.WriteLine("Email enviado para: "+this.pedido.consumidor.nome);
            Console.WriteLine(mensagem);
        }
    }
}
