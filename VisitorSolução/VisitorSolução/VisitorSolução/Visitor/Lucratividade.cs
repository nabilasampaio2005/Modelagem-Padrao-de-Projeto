using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorSolução.ElementosConcretos;

namespace VisitorSolução.Visitor
{
    public class Lucratividade : Visitor
    {
        public double visitSupermercado(Supermercado supermercado)
        {
            double lucroSupermercado = 0;
            foreach (var departamento in supermercado.departamentos)
            {
                lucroSupermercado += visitDepartamento(departamento);
            }
            return lucroSupermercado;
        }

        public double visitDepartamento(Departamento departamento)
        {
            double lucroDepartamento = 0;
            foreach (var produto in departamento.produtos)
            {
                lucroDepartamento += visitProduto(produto);
            }
            return lucroDepartamento;
        }


        public double visitProduto(Produto produto)
        {
            return produto.preco * (produto.margemLucro / 100);
        }
    }
}