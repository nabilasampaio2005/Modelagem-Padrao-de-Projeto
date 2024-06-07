using ObserverSolucao.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverSolucao.Subjects
{
	public class Email
	{
		public static void enviarEmail(Observer observer, string mensagem)
		{
			Console.WriteLine("---------------------------------------------------------------------");
			Console.WriteLine("Email enviado para: " + observer.getNome() + " - " + observer.getEmail);
			Console.WriteLine("Mensagem: " + mensagem);		
		}
	}
}
