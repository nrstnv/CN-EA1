using System.Collections;

namespace Aufgabe3
{
    /* creating abstract class of Subject */
    abstract class Subject : IObservable
    {
        private ArrayList observers = new ArrayList();

        public void NotifyObservers(object o)
        {
            foreach (IObserver observer in observers)
                observer.DisplayNumber(o);
        }

        public void RegisterObserver(IObserver newObserver)
        {
            /* Check whether new observer is already registered. 
                * If not, add it */
            if (!observers.Contains(newObserver))
                observers.Add(newObserver);
        }

        public void UnregisterObserver(IObserver deleteObserver)
        {
            observers.Remove(deleteObserver);
        }
    }
}
