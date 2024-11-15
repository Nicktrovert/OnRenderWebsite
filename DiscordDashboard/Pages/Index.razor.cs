using DiscordDashboard.Code;

namespace DiscordDashboard.Pages
{
    public partial class Index : ICounterObserver, IDisposable
    {
        public void Update(ICounterObservable observable)
        {
            InvokeAsync(StateHasChanged);
        }

        public void Dispose()
        {
            testStuff.Detach(this);
        }
    }
}
