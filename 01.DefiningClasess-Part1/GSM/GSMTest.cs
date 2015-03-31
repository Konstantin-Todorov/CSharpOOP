

namespace GSM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class GSMTest
    {
        public void CreateAFewGSMs(int num)
        {
            List<GSM> gsms = new List<GSM>();
            for (int i = 0; i < num; i++)
            {
                gsms.Add(new GSM("modern " + i + " GSM", "apple"));
            }

            foreach (var gsm in gsms)
            {
                Console.WriteLine(gsm.Model);
                Console.WriteLine(gsm.Manufacturer);
                Console.WriteLine(GSM.IPhone4SInfo);
            }
        }
    }
}
