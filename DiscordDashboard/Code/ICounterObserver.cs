namespace DiscordDashboard.Code
{
    public interface ICounterObserver
    {
        void Update(ICounterObservable observable);
    }
}
