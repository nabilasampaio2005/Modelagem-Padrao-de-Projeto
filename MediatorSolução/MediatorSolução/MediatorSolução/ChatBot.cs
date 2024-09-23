using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorSolução
{
    public class ChatBot : Usuario
    {
        private Usuario ultimoUsuario;

        public ChatBot(string nome) : base(nome)
        {
            this.ultimoUsuario = this;
        }
        public override void enviar(string mensagem)
        {
            if (this.mediator == null)
            {
                Console.WriteLine($"{this.getNome()} não está mais moderando uma sala de chat e " +
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

        public Boolean validarMensagem(Usuario usuario)
        {
            if (this.ultimoUsuario.Equals(usuario))
            {
                this.enviar(mensagem: $"Uma mensagem de " +
                    $"{usuario.getNome()} foi negada");
            }
            this.ultimoUsuario = usuario;
            return true;
        }
    }
}
