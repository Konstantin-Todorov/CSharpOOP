//Problem 20: By using delegates develop an universal static method to calculate the sum of infinite 
//    convergent series with given precision depending on a function of its term. By using proper functions 
//    for the term calculate with a 2-digit precision the sum of the infinite series:
 
//        Example 1: 1 + 1/2 + 1/4 + 1/8 + 1/16 + …
//        Example 2: 1 + 1/2! + 1/3! + 1/4! + 1/5! + …
//        Example 3: 1 + 1/2 - 1/4 + 1/8 - 1/16 + …

namespace ConvergentSeries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ConvergientMain
    {
        static void Main()
        {
            Console.WriteLine("1 + 1/2 + 1/4 + 1/8 + 1/16 + …");
            Console.WriteLine(Convergent.ConvergentSum(index => 1 / Math.Pow(2, index - 1), 0.01));
            Console.WriteLine("1 + 1/2 - 1/4 + 1/8 - 1/16 + …");
            Console.WriteLine(Convergent.ConvergentSum(index =>
            {
                if ((index % 2) == 0)
                {
                    return 1 / Math.Pow(2, index - 1);
                }
                else
                {
                    return (1 / Math.Pow(2, index - 1)) * -1;
                }
            }, 0.01));             
        }
    }
}
