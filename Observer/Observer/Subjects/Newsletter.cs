using ObserverSolucao.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverSolucao.Subjects
{
	public class Newsletter : Subject
	{
		private List<Observer>? observers;
		private List<string> emails;

		public Newsletter()
		{
			this.observers = new List<Observer>();
			this.emails = new List<string>();
		}
		public void addMenssage(string message)
		{
			this.emails.Add(message);
			this.notifyObserver();
		}

		public void notifyObserver()
		{
			foreach(Observer observer in observers)
			{
				observer.update(emails.Last());
			}
		}

		public void registerObserver(Observer observer)
		{
			this.observers.Add(observer);
		}

		public void removeObserver(Observer observer)
		{
			for (int i = 0; i < observers.Count; i++) 
			{ 
				Observer observerReg = observers[i];
				if(observerReg.Equals(observer))
					observers.Remove(observerReg);
			}
		}
	}
}
