using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorSolucao.IteratorModel
{
    public class MatrizIterator : Iterator
    {
        public Matriz matriz;
        public int indiceLinha { get; set; } = 0;
        public int indiceColuna { get; set; } = 0;
        public int qtdLinhas { get; set; }
        public int qtdColunas { get; set; }

        public MatrizIterator(Matriz matriz)
        {
            this.matriz = matriz;
            this.qtdLinhas = matriz.getQuantidadeLinhas();
            this.qtdColunas = matriz.getQuantidadeLinhas();
        }

        public void incrementarIndice()
        {
            if (this.indiceColuna >= this.qtdColunas-1)
            {
                this.indiceLinha = this.indiceLinha + 1;
                this.indiceColuna = 0;
            } else
            {
                this.indiceColuna += 1;
            }
        }

        public bool hasNext()
        {
            if(this.indiceLinha > (this.qtdLinhas - 1))
            {
                return false;
            }
            return true;
        }

        public int next()
        {
            int item = this.matriz.getItem(this.indiceLinha, this.indiceColuna);
            this.incrementarIndice();
            return item;
        }
    }
}
