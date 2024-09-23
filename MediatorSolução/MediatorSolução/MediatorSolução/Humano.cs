using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorSolução
{
    public class Humano : Usuario
    {
        public Humano(string nome) : base(nome) { }
        public override void enviar(string mensagem)
        {
            if (this.mediator == null)
            {
                Console.WriteLine($"{this.getNome()} não está mais na sala de chat e " +
                    $"não pode enviar mensagens.");
            }

            Console.WriteLine($"---------------{this.nome}---------------");
            Console.WriteLine($"{this.getNome()} enviou: {mensagem}");
            this.mediator.enviarMensagem(mensagem, usuario: this);
        }

        public override void receber(string mensagem)
        {
           Console.WriteLine($"{this.getNome()} recebeu: {mensagem}");
        }
    }
}
