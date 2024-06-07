using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeProblema.cadastros
{
    public class Consumidor
    {
        public String nome { get; set; }
        public String cpf { get; set;}
        public String email { get; set; }

        public Consumidor(string nome, string cpf, string email)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
        }
    }
}
