using CommandSolucao.devices;

namespace CommandSolucao.Commands
{
    public class MudarTemperaturaArCondicionado : Command
    {
        private ArCondicionado arCondicionado;
        private int temperatura;
        private int temperaturaAnterior;

        public MudarTemperaturaArCondicionado(ArCondicionado arCondicionado)
        {
            this.arCondicionado = arCondicionado;
            this.temperatura = arCondicionado.getTemperatura();
        }

        public void setTemperatura(int temperatura)
        {
            this.temperaturaAnterior = this.temperatura;
            this.temperatura = temperatura;
        }

        public void desfazer()
        {
            //no metodo desfazer, seta a temperatura anterior
            this.arCondicionado.setTemperatura(this.temperaturaAnterior);

            //chamar o metodo toString() para feedback
            this.arCondicionado.tostring();
        }

        public void executar()
        {
            //no metodo desfazer, seta a temperatura
            this.arCondicionado.setTemperatura(this.temperatura);
            //chamar o metodo toString() para feedback
            this.arCondicionado.tostring();
        }
    }
}