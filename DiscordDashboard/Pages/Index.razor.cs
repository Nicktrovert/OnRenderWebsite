using DiscordDashboard.Code;

namespace DiscordDashboard.Pages
{
    public partial class Index : ICounterObserver
    {
        public void Update(ICounterObservable observable)
        {
            InvokeAsync(StateHasChanged);
        }
    }
}
