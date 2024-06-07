using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorSolucao.IteratorModel
{
    public class Matriz : Agregado
    {
        public int[,] matriz;
        public int linhaAtual { get; set; } 
        public int colunaAtual { get; set; } 
        public int quantLinhas { get; set; }
        public int quantColunas { get; set; }

        public Matriz(int qtdLinhas, int qtdColunas)
        {
            matriz = new int[qtdLinhas, qtdColunas];
            this.quantLinhas = qtdLinhas;
            this.quantColunas = qtdColunas;
        }

        public int getItem(int linha, int coluna)
        {
            return this.matriz[linha, coluna];
        }

        public int getQuantidadeLinhas()
        {
            return this.quantLinhas;
        }

        public Boolean addItem(int item)
        {
            if(this.linhaAtual == (this.quantLinhas) &&
                this.colunaAtual == (this.quantColunas))
            {
                return false;
            }

            if(this.colunaAtual == (this.quantColunas))
            {
                this.linhaAtual += 1;
                this.colunaAtual = 0;
            }

            this.matriz[this.linhaAtual, this.colunaAtual] = item;
            this.colunaAtual += 1;
            return true;
        }

        public int getQuantidadeColunas()
        {
            return this.quantColunas;
        }
        public Iterator createIterator()
        {
            return new MatrizIterator(this);
        }
    }
}
