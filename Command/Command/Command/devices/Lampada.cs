namespace CommandSolucao.devices
{
    public class Lampada
    {
        public String identificacao { get; set; }
        public Boolean estado { get; set; }

        public Lampada(string identificacao, bool estado)
        {
            this.identificacao = identificacao;
            this.estado = estado;
        }

        public void ligar()
        {
            this.estado = true;
        }

        public void desligar()
        {
            this.estado = false;
        }

        public String getIdentificacao()
        {
            return this.identificacao;
        }

        public Boolean getEstado()
        {
            return this.estado;
        }

        public void tostring()
        {
            string texto = $"O dispositivo {this.identificacao} esta {(this.estado ? "ligado" : "desligado")}";
            Console.WriteLine(texto);
        }
    }
}