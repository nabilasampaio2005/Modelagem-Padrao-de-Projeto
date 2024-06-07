using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorSolucao.IteratorModel
{
    public class ImpressoraDeAgregados
    {
        public Agregado agregado {  get; set; }
        public void iterar()
        {
            Iterator iterator = this.agregado.createIterator();
            while (iterator.hasNext())
            {
                Console.WriteLine(iterator.next() + " ");
            }
        }
    }
}
