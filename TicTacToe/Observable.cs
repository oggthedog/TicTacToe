using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public interface IObserver
    {
        void Update(object arg0, object arg1);
      
    }

    public class Observable
    {
        private bool Changed;
        private List<IObserver> Observers;
        public Observable()
        {
            Observers = new List<IObserver>();
        }
        public void SetChanged()
        {
            Changed = true;
        }
        public void NotifyObservers(object arg1 = null)
        {
            foreach (var o in Observers)
            {
                o.Update((object)this, arg1);
            }
        }
        public void AddObserver(IObserver observer)
        {
            Observers.Add(observer);
        }
    }
}

