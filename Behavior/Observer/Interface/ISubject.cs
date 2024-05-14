

namespace DesingPatterns.Behavior.Observer.Interface
{
    public interface ISubject
    {
        void Add(IObserver observer);
        void Notify();
    }
}
