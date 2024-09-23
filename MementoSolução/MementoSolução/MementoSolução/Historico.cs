using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoSolução
{
    public class Historico
    {
       public List<MementoInterface> historico { get; set; } = new List<MementoInterface>();
        public OriginadorInterface ultimoOriginador;

        public void criarCheckPoint(OriginadorInterface originador)
        {
            this.ultimoOriginador = originador;
            this.historico.Add(originador.salvar());
        }

        public void desfazer()
        {
            if (this.historico.Count <= 0)
            {
                return;
            }

            var memento = this.historico[this.historico.Count - 1];
            memento.restaurar();

            this.historico.RemoveAt(this.historico.Count - 1);
        }

        public void imprimir ()
        {
            if (ultimoOriginador != null)
            {
                ultimoOriginador.imprimir();
            }
            else
            {
                Console.WriteLine("Nenhum estado salvo para imprimir.");
            }
        }

    }
}
