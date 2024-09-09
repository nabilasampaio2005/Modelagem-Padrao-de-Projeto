using BridgeSolucao.Canal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSolucao.Mensagem
{
    public class MensagemAdmin : Mensagem
    {
        public MensagemAdmin(CanalDeEnvio canal) : base(canal) 
        {
        
        }

        public override void enviarMensagem()
        {
            Console.WriteLine("Mensagem enviada pelo administrador");
            base.canal.enviarMensagem(base.assunto, base.mensagem);
        }
    }
}
