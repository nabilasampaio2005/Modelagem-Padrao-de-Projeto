using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeProblema.cadastros
{
    public class Produto
    {
        public String nome { get; set; }
        public String descricao { get; set; }
        public double valor { get; set; }

        public Produto(string nome, string descricao, double valor)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.valor = valor;
        }
    }
}
