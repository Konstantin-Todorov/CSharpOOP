namespace Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Handler
    {
        public Handler(Publisher pub)
        {
            pub.RaiseTimeEvent += HandleTimerEvent;
        }

        public static void HandleTimerEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Event Raised: {0}", DateTime.Now);
        }
    }
}
