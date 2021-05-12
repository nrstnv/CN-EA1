namespace Aufgabe3
{
    /* creating the Subject interface */
    public interface IObservable
    {
        void NotifyObservers(object o);
        void RegisterObserver(IObserver observer);
        void UnregisterObserver(IObserver observer);
    }
}
