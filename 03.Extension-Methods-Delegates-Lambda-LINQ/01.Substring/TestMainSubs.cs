//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.
namespace Substring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Extensions;

    public class TestMainSubs
    {
        public static void Main()
        {
            string test = "testing the substringbuilder";
            var sb = new StringBuilder();
            sb.Append(test);

            Console.WriteLine(sb.SubStringBuilder(0, 8));
            Console.WriteLine(sb.SubStringBuilder(8));
        }
    }
}
