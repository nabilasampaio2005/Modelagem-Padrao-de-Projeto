using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeSolucao
{
    public class GerenciadorArquivo
    {
        private Component raiz;

        public GerenciadorArquivo(Component raiz)
        {
            this.raiz = raiz;
        }

        public void exibirTodos()
        {
            this.raiz.exibir();
        }
    }
}
