using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorSolução.ElementosConcretos
{
    public class Supermercado : Elemento
    {
        public string nome { get; set; }
        public List<Departamento> departamentos { get; set; }

        public Supermercado() { }

        public Supermercado(string nome)
        {
            this.nome = nome;
            this.departamentos = new List<Departamento>();
        }

        public void addDepartamento(Departamento departamento)
        {
            this.departamentos.Add(departamento);
        }

        public double aceitar(Visitor.Visitor visitor)
        {
            return visitor.visitSupermercado(this); 
        }
    }
}
