using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSolucao.Canal
{
    public interface CanalDeEnvio
    {
        public void enviarMensagem(String assunto, String mensagem);
    }
}
