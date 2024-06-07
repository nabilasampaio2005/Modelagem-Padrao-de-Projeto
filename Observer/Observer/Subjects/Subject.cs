using ObserverSolucao.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverSolucao.Subjects
{
	public interface Subject
	{
		public void registerObserver(Observer observer);	
		public void removeObserver(Observer observer);
		public void notifyObserver();
		public void addMenssage(string message);
	}
}
