namespace OnRenderWebsite.Code.Base
{
    using System;
    using System.Threading;

    public class KeepAlive
    {
        private readonly int _interval; // Interval in milliseconds
        private Thread _keepAliveThread;
        private volatile bool _running;


        public KeepAlive(int interval)
        {
            _interval = interval;
        }


        public void Start()
        {
            if (!_running)
            {
                _running = true;
                _keepAliveThread = new Thread(KeepAliveLoop);
                _keepAliveThread.Start();
            }
        }

        public void Stop()
        {
            _running = false;
            if (_keepAliveThread != null)
            {
                _keepAliveThread.Join(); // Wait for the thread to finish
            }
        }

        private void KeepAliveLoop()
        {
            while (_running)
            {
                KeepAliveMethod();
                Thread.Sleep(_interval);
            }
        }

        protected virtual void KeepAliveMethod()
        {
            // This method will be called repeatedly.
            Global.Logger.LogInformation("KeepAlive method is running...");
        }
    }
}
