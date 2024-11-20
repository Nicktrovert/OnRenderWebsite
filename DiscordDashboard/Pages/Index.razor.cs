using OnRenderWebsite.Code;

namespace OnRenderWebsite.Pages
{
    public partial class Index : IObserverC, IDisposable
    {
        public void Update(IObservableC observable)
        {
            InvokeAsync(StateHasChanged);
        }

        public void Dispose()
        {
            counterManager.Detach(this);
        }
    }
}
