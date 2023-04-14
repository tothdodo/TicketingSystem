using System.Threading;

namespace TicketingSystemAPI.TimerFeatures
{
    public class TimerManager
    {
        private Timer _timer;
        private Action _action;
        private AutoResetEvent _autoResetEvent;

        public DateTime TimeStarted { get; set; }

        public TimerManager(Action action)
        {
            _action = action;
            _autoResetEvent = new AutoResetEvent(false);
            _timer = new Timer(Execute, _autoResetEvent, 1000, 2000);
            TimeStarted = DateTime.Now;
        }

        private void Execute(object? stateInfo)
        {
            _action();

            if((DateTime.Now - TimeStarted).Seconds > 5)
            {
                _timer.Dispose();
            }
        }
    }
}
