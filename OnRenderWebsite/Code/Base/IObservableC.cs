namespace OnRenderWebsite.Code.Base
{
    public interface IObservableC
    {
        void Attach(IObserverC observer);
        void Detach(IObserverC observer);
        void Notify();
    }
}
