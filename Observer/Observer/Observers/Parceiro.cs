using ObserverSolucao.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverSolucao.Observers
{
	public class Parceiro : Observer
	{
		private string nome;
		private string email;

		public Parceiro(string nome, string email)
		{
			this.nome = nome;
			this.email = email;
		}

		public override bool Equals(object? obj)
		{
			return obj is Parceiro parceiro &&
				nome == parceiro.nome &&
				email == parceiro.email;
		}
		public string getEmail()
		{
			return this.email;
		}

		public string getNome()
		{
			return this.nome;
		}

		public void update(string mensagem)
		{
			Email.enviarEmail(this, mensagem);
		}
	}
}
