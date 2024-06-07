using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorSolucao.IteratorModel
{
    public class Lista : Agregado
    {
        private List<int> lista = new List<int>();
        private int tamanho { get; set; }

        public Lista(int tamanho)
        {
            this.tamanho = tamanho;
        }

        public Boolean addItem(int item)
        {
            if(this.lista.Count() <=(this.tamanho-1))
            {
                this.lista.Add(item);
            }
            return true;
        }

        public int getTamanho()
        {
            return this.tamanho;
        }

        public int getItem(int indice)
        {
            return this.lista[indice];
        }

        public Iterator createIterator()
        {
            return new ListaIterator(this);
        }
    }
}
