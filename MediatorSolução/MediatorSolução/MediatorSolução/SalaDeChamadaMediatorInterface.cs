using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorSolução
{
    public interface SalaDeChamadaMediatorInterface
    {
        public void enviarMensagem(string mensagem, Usuario usuario);
        public void adicionarUsuario(Usuario usuario);

        public void removerUsuario(Usuario usuario);
    }
}
