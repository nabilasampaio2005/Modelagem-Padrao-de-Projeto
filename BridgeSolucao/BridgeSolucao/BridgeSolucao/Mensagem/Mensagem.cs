using BridgeSolucao.Canal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSolucao.Mensagem
{
    public abstract class Mensagem
    {
        public CanalDeEnvio canal {  get; set; }
        public String assunto { get; set; }
        public String mensagem { get; set; }

        public Mensagem(CanalDeEnvio canal) {
            this.canal = canal;
            this.assunto = "";
            this.mensagem = "";
        }

        public void setAssunto(String assunto)
        {
            this.assunto = assunto;
        }
        public void setMensagem(String mensagem)
        {
            this.mensagem = mensagem;
        }
        public abstract void enviarMensagem();
    }
}
