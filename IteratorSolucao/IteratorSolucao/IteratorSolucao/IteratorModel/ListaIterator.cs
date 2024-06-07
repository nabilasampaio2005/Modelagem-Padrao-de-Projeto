using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorSolucao.IteratorModel
{
    public class ListaIterator : Iterator
    {
        private Lista lista;
        private int indice { get; set; } = 0;
        private int tamanho { get; set; }

        public ListaIterator(Lista lista)
        {
            this.lista = lista;
            this.tamanho = lista.getTamanho();
        }
        public bool hasNext()
        {
            if(this.indice >= this.tamanho)
            {
                return false;
            }
            return true;
        }

        public int next()
        {
            int item = this.lista.getItem(this.indice);
            this.indice+=1;
            return item;
        }
    }
}
