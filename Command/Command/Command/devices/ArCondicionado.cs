namespace CommandSolucao.devices
{
    public class ArCondicionado
    {
        public String identificacao { get; set; }
        public Boolean estado { get; set; }
        public int temperatura { get; set; }

        public ArCondicionado(string identificacao, bool estado, int temperatura)
        {
            this.identificacao = identificacao;
            this.estado = estado;
            this.temperatura = temperatura;
        }

        public void ligar()
        {
            this.estado = true;
        }

        public void desligar()
        {
            this.estado = false;
        }

        public void setTemperatura(int temperatura)
        {
            this.temperatura = temperatura;
        }

        public String getIdentificacao()
        {
            return this.identificacao;
        }

        public Boolean getEstado()
        {
            return this.estado;
        }

        public int getTemperatura()
        {
            return this.temperatura;
        }

        public void tostring()
        {
            String texto = $"O dispositivo esta {(this.estado ? "ligado" : "desligado")} a {this.temperatura} graus celsius";
            Console.WriteLine(texto);
        }
    }
}