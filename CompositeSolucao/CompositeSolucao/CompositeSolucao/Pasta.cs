using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeSolucao;
    public class Pasta : Component
    {
        public String? nome;
        public String? caminho;
        public List<Component> componentes;

        public Pasta(string? nome, string? caminho)
        {
            this.nome = nome;
            this.caminho = caminho;
            this.componentes = new List<Component>();
        }

        public override void adicionar(Component componente)
        {
            this.componentes.Add(componente);
        }

        public override void remover(Component componente)
        {
            foreach (var comp in this.componentes)
            {
                if (comp == componente)
                {
                    componentes.Remove(comp);
                }
            }
        }

        public override Component recuperarFilho(int indice)
        {
            return this.componentes[indice];
        }

        public override void exibir()
        {
            String retorno = $" - {this.nome} - [{this.caminho}]";
            Console.WriteLine("---------------------------------");
            Console.WriteLine(retorno);

            foreach (var comp in this.componentes)
            {
                comp.exibir();
            }
        }

        public String getNome()
        {
            return this.nome;
        }

        public String getCaminho() 
        {
            return this.caminho;
        }

    }
