using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSolucao.Canal
{
    public class Email : CanalDeEnvio
    {
        public void enviarMensagem(string assunto, string mensagem)
        {
            String saida = $"Email enviado: {assunto} - Mensagem: {mensagem}";
            Console.WriteLine(saida);   
        }
    }
}
