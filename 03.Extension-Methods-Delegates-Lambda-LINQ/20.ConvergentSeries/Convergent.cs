namespace ConvergentSeries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Convergent
    {
        public static double ConvergentSum(Func<int, double> termValue, double precision)
        {
            double result = 0;
            int element = 0;

            while (true)
            {
                double perscisionResult = termValue(element);
                result += perscisionResult;
                if (perscisionResult < precision)
                {
                    break;
                }
                element++;
            }

            return result;
        }
    }
}
