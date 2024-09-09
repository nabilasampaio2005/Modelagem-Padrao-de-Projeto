using CommandSolucao.Commands;

namespace CommandSolucao.devices
{
    public class Aplicativo
    {
        private List<Command> comandos = new List<Command>();
        //para um comando ser adicionado a lisa de comandos do app ele precisa implementar a interface command, assim sabemos que ele possui metodo executar.

        public int setComando(Command Comando)
        {
            //adiciona o comando na ultima posicao
            this.comandos.Add(Comando);
            //retorna para o cliente a posição do array em que foi inserido
            return comandos.Count - 1;
        }

        //metodo que sera chamado sempre sera q um botao for press. na interface do app passando o indice a ser desfeito

        public void aoPrecionarBotao(int id)
        {
            this.comandos[id].executar();
        }
        public void duploCliqueBotao(int id)
        {
            this.comandos[id].desfazer();
        }

        //retorna um comando do app.

        public Command GetComando(int id)
        {
            return this.comandos[id];
        }
    }
}