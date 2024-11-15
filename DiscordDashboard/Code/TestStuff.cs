namespace DiscordDashboard.Code
{
    public sealed class TestStuff
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
            set => _counter = value;
        }

    }
}
