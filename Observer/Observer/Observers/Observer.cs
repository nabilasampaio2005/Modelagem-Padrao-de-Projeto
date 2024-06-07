using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverSolucao.Observers
{
	public interface Observer
	{
		public void update(string mensagem);
		public string getNome();
		public string getEmail();
	}
}
