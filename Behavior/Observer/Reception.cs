
using DesingPatterns.Behavior.Observer.Interface;

namespace DesingPatterns.Behavior.Observer
{
    public class Reception : ISubject
    {
        private List<IObserver> observers;
        public string _sector { get; set; }
        public string Sector 
        {
            get { return _sector; }
            set
            {
                _sector = value;
                NotificationManager();
            }

        }
      
        public Reception()
        {
            observers = new List<IObserver>();
        }

        public void Add(IObserver observer)
               => observers.Add(observer);
        

        public void Notify() 
            => observers.ForEach(o => {o.Update(this);});
        
        private void NotificationManager() =>  Notify();
             
    }
}
