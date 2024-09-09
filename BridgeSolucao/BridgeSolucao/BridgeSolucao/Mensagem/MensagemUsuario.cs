using BridgeSolucao.Canal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSolucao.Mensagem
{
    public class MensagemUsuario : Mensagem
    {
        public MensagemUsuario(CanalDeEnvio canal) : base(canal)
        {

        }

        public override void enviarMensagem()
        {
            Console.WriteLine("Mensagem enviada pelo usuario");
            base.canal.enviarMensagem(base.assunto, base.mensagem);
        }
    }
}
