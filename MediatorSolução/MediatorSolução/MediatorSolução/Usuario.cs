using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorSolução
{
    public abstract class Usuario
    {
        protected SalaDeChamadaMediatorInterface mediator = null;

        protected string nome { get; set; }

        protected Usuario(string nome)
        {
            this.nome = nome;
        }

        public void setMediator(SalaDeChamadaMediatorInterface mediator)
        {

            if (mediator == null)
            {
                this.mediator = null;
                return;
            }
            if (!(this.mediator is null))
            {
                this.mediator.removerUsuario(this);
            }
            this.mediator = mediator;
            this.mediator.adicionarUsuario(this);


        }

        public string getNome() 
        {
            return this.nome;
        }

        public abstract void enviar(string mensagem);
        public abstract void receber(string mensagem);
    }
}
