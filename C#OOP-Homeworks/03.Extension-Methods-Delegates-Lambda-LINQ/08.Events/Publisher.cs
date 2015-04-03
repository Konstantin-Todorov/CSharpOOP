namespace Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;

    public delegate void TimeElapseEventHendler (object sender, Publisher p );

    public class Publisher : EventArgs
    {
        public event EventHandler RaiseTimeEvent;

        public void Start (int ticks , int interval)
        {
            int start = 0;
            
            while (start <= interval)
            {
                Thread.Sleep(start * 500);
                start += ticks;
                OnRaiseTimerEvent();
            }
        }

        protected void OnRaiseTimerEvent()
        {
            EventHandler e = RaiseTimeEvent;

            if (e != null)
            {
                e(this, null);
            }

        }
    }
}
