namespace OnRenderWebsite.Code
{
    public sealed class CounterManager : IObservableC
    {
        private CounterManager(){}

        private static CounterManager _instance;

        public static CounterManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CounterManager();
            }
            return _instance;
        }

        private int _counter = 0;

        public int Counter
        {
            get => _counter;
            set
            {
                _counter = value;
                Notify();
            }
        }

        public List<IObserverC> _observers = new List<IObserverC>();

        public void Attach(IObserverC observer)
        {
            _instance._observers.Add(observer);
        }

        public void Detach(IObserverC observer)
        {
            _instance._observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserverC observer in _instance._observers)
            {
                observer.Update(this);
            }
        }
    }
}
