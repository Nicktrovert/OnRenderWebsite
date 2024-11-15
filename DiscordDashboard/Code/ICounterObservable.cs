namespace DiscordDashboard.Code
{
    public interface ICounterObservable
    {
        void Attach(ICounterObserver observer);
        void Detach(ICounterObserver observer);
        void Notify();
    }
}
