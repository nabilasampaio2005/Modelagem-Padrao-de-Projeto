using CommandSolucao.devices;

namespace CommandSolucao.Commands
{
    internal class LigarArCondicionado : Command
    {
        private ArCondicionado arCondicionado;

        public LigarArCondicionado(ArCondicionado arCondicionado)
        {
            this.arCondicionado = arCondicionado;
        }

        public void desfazer()
        {
            //no metodo desfazer, chamar o metodo desligar 
            this.arCondicionado.desligar();

            //chamar o metodo toString() para feedback
            this.arCondicionado.tostring();
        }

        public void executar()
        {
            //no metodo desfazer, chamar o metodo ligar 
            this.arCondicionado.ligar();
            //chamar o metodo toString() para feedback
            this.arCondicionado.tostring();
        }
    }
}