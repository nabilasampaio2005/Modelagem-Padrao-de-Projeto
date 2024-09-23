using MediatorSolução;
using System;

namespace MediatorSolucao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação do Chatbot moderador
            ChatBot moderador = new ChatBot("CHATBOT");

            // Criação da Sala de Chat e chatbot como moderador.
            SalaDeChatMediator salaDeChat = new SalaDeChatMediator(moderador, "sala 1");

            // Criação de Usuários
            Usuario usuario1 = new Humano("Alice");
            Usuario usuario2 = new Humano("Bob");
            Usuario usuario3 = new Humano("Charlie");

            // Adiciona usuários à sala de chat
            Console.WriteLine("Adicionando usuários à sala de chat...");
            usuario1.setMediator(salaDeChat);
            usuario2.setMediator(salaDeChat);
            usuario3.setMediator(salaDeChat);

            usuario1.entrar(salaDeChat);
            usuario2.entrar(salaDeChat);
            usuario3.entrar(salaDeChat);

            // Enviar mensagens
            Console.WriteLine("Alice envia uma mensagem:");
            usuario1.enviar("Oi pessoal");

            // Bob envia uma mensagem consecutiva
            Console.WriteLine("Bob envia duas mensagens consecutivas:");
            usuario2.enviar("Oi Alice!");
            usuario2.enviar("Como você está?");

            // Charlie envia uma mensagem
            Console.WriteLine("Charlie envia uma mensagem:");
            usuario3.enviar("Bom dia a todos!");

            // Remover um usuário da sala de chat
            Console.WriteLine("Removendo Bob da sala de chat...");
            salaDeChat.removerUsuario(usuario2);

            // Tentativa de Bob enviar uma mensagem após ser removido
            Console.WriteLine("Bob tenta enviar uma mensagem após ser removido:");
            usuario2.enviar("Ainda estou aqui!");

            // Alice envia uma mensagem após Bob ser removido
            Console.WriteLine("Alice envia uma mensagem após Bob ser removido:");
            usuario1.enviar("Parece que Bob saiu.");

            Console.WriteLine("Fim do teste.");

            Console.WriteLine("\nAlice envia uma mensagem:");
            usuario1.enviar(mensagem: "oi pessoal");

            Console.WriteLine("\nBob envia duas mensagens consecutivas:");
            usuario2.enviar(mensagem: "Olá Alice");
            usuario2.enviar(mensagem: "Como você está?");
        }
    }
}
