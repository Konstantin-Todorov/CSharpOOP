﻿using System.Diagnostics.Eventing.Reader;

namespace GSM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class GSMCallHistoryTest
    {
        public void TestHistoryCalls()
        {
            GSM myGoodGSM = new GSM("nokiaFener", "nokia");

            List<Call> afewCalls = new List<Call>();
            for (int i = 0; i < 6; i++)
            {
                afewCalls.Add(new Call(DateTime.Now, DateTime.Now, "0889876543", "0881234567", i + 0.3));
            }
            foreach (var afewCall in afewCalls)
            {
                myGoodGSM.AddCalls(afewCall);
            }

            double money = myGoodGSM.CalculateTotalPrice(0.37);
            Console.WriteLine("Spent money for calls: {0}", money);
            double longestDuration = 0;
            int indexOfLongestCall = 0;
            for (int i = 0; i < afewCalls.Count; i++)
            {
                if (afewCalls[i].Duration >= longestDuration)
                {
                    longestDuration = afewCalls[i].Duration;
                    indexOfLongestCall = i;
                }
            }
            myGoodGSM.DeleteCalls(afewCalls[indexOfLongestCall]);
            money = myGoodGSM.CalculateTotalPrice(0.37);
            Console.WriteLine("Spent money for calls after removing the longest: {0}", money);

            for (int i = 0; i < myGoodGSM.CallHistory.Count; i++)
            {
                Console.WriteLine("{0} called {1} for {2} minutes at {3}", myGoodGSM.CallHistory[i].Number, myGoodGSM.CallHistory[i].DialedPhone, myGoodGSM.CallHistory[i].Duration, myGoodGSM.CallHistory[i].Time);
            }

            myGoodGSM.ClearCallHistory();
        }
    }
}
