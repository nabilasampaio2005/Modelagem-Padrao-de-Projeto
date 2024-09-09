using CommandSolucao.devices;

namespace CommandSolucao.Commands
{
    internal class DesligarArCondicionado : Command
    {
        private ArCondicionado arCondicionado;

        public DesligarArCondicionado(ArCondicionado arCondicionado)
        {
            this.arCondicionado = arCondicionado;
        }

        public void desfazer()
        {
            //no metodo desfazer, chamar o metodo desligar 
            this.arCondicionado.ligar();

            //chamar o metodo toString() para feedback
            this.arCondicionado.tostring();
        }

        public void executar()
        {
            //no metodo desfazer, chamar o metodo ligar 
            this.arCondicionado.desligar();
            //chamar o metodo toString() para feedback
            this.arCondicionado.tostring();
        }
    }
}