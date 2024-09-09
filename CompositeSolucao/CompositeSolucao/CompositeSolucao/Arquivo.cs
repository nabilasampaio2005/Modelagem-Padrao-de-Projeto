using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeSolucao;

public class Arquivo : Component
{
    public String? nome;
    public String? caminho;

    public Arquivo(string? nome, string? caminho)
    {
        this.nome = nome;
        this.caminho = caminho;
    }

    public String getNome()
    {
        return this.nome;
    }

    public String getCaminho()
    {
        return this.caminho;
    }

    public override void exibir()
    {
        String retorno = $" - {this.nome} - [{this.caminho}]";
        Console.WriteLine(retorno);
    }

    public override void adicionar(Component componente)
    {
        throw new NotImplementedException();
    }

    public override void remover(Component componente)
    {
        throw new NotImplementedException();
    }

    public override Component recuperarFilho(int indice)
    {
        throw new NotImplementedException();
    }
}
