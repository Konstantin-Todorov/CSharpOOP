namespace Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EventsTimerMain
    {
        static void Main()
        {
            Publisher pub = new Publisher();
            Handler hand = new Handler(pub);

            pub.Start(5, 10);
        }
    }
}
