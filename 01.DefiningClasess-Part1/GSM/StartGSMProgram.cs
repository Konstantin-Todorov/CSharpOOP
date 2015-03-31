using System.ComponentModel;
using System.Security.Cryptography;

namespace GSM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class StartGSMProgram
    {
        public class StartProgram
        {
            private static void Main(string[] args)
            {
                //#Input
                //Console.WriteLine("Enter phone model:");
                //string model = Console.ReadLine();
                //Console.WriteLine("Enter phone manufacturer:");
                //string manufacturer = Console.ReadLine();
                //Console.WriteLine("Enter hours of idle: (Not necessery, press enter to skip!)");
                //string currentHoursIdle = Console.ReadLine();
                //double? currentHoursIdleD = null;
                //if (currentHoursIdle.Length != 0)
                //    currentHoursIdleD = double.Parse(currentHoursIdle);
                //Console.WriteLine("Enter hours of talk: (Not necessery, press enter to skip!)");
                //string currentHoursIdTalk = Console.ReadLine();
                //double? currentHoursTalkD = null;
                //if (currentHoursIdle.Length != 0)
                //    currentHoursTalkD = double.Parse(currentHoursIdTalk);
                //Console.WriteLine("Enter phone display size: (Not necessery, press enter to skip!) ");
                //string currentDisplaySize = Console.ReadLine();
                //double? currentDisplaySizeD = null;
                //if (currentDisplaySize.Length != 0)
                //    currentDisplaySizeD = double.Parse(currentDisplaySize);
                //Console.WriteLine("Enter phone colors: (Not necessery, press enter to skip!)");
                //string currentColor = Console.ReadLine();
                //long colors = 12334123;
                //if (currentColor.Length != 0)
                //{
                //    colors = long.Parse(currentColor);
                //}

                GSMCallHistoryTest test = new GSMCallHistoryTest();
                test.TestHistoryCalls();
            }
        }
    }
}
