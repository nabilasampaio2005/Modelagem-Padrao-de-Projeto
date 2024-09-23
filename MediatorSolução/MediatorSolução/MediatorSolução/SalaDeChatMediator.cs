using MediatorSolução;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MediatorSolucao
{
    public class SalaDeChatMediator : SalaDeChamadaMediatorInterface
    {
        
        private List<Usuario> usuarios;
        private ChatBot chatBot;
        private string nome;

        public SalaDeChatMediator(ChatBot chatBot, string nome)
        {
            //Inicializa a lista de usuários com vazio.
            this.usuarios = new List<Usuario>();
            //Cria a referência do Chatbot moderador
            this.chatBot = chatBot;
            this.nome = nome;
            //Notifica o chat que deve moderar esta sala de chat.
            this.chatBot.setMediator(this);
        }

        public void enviarMensagem(string mensagem, Usuario usuario)
        {
            if (this.chatBot.validarMensagem(usuario))
            {
                foreach (var u in this.usuarios) // Sintaxe correta para o foreach
                {
                    if (!u.Equals(usuario))
                    {
                        u.receber(mensagem);
                    }
                }
                Console.WriteLine("----------------------------");
            }
        }


        public void adicionarUsuario(Usuario usuario)
        {
            this.usuarios.Add(usuario);
        }

        public void removerUsuario(Usuario usuario)
        {
            //Verifica se o usuário está presente na lista
            if (this.usuarios.Contains(usuario))
            {
                this.usuarios.Remove(usuario);
                //Notifica o moderador como Anti, indicando que o usuário foi removido.
                Console.WriteLine($"{usuario.getNome()} foi removido da sala de chat {this.getNome}");
            }
        }

        public string getNome()
        {
            return this.nome;
        }
    }
}

