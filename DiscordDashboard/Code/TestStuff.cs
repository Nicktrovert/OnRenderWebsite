namespace DiscordDashboard.Code
{
    public sealed class TestStuff : ICounterObservable
    {
        private TestStuff(){}

        private static TestStuff _instance;

        public static TestStuff GetInstance()
        {
            if (_instance == null)
            {
                _instance = new TestStuff();
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

        public List<ICounterObserver> _observers = new List<ICounterObserver>();

        public void Attach(ICounterObserver observer)
        {
            this._observers.Add(observer);
        }

        public void Detach(ICounterObserver observer)
        {
            this._observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (ICounterObserver observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
