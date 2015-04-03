namespace Substring.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class SubStringBuilderExtensions
    {
        public static StringBuilder SubStringBuilder(this StringBuilder sb, int position)
        {
            string result = sb.ToString().Substring(position,sb.Length - position);
            StringBuilder resultSb = new StringBuilder(result);
            return resultSb;
        }
        public static StringBuilder SubStringBuilder(this StringBuilder sb, int position, int lenght)
        {
            string result = sb.ToString().Substring(position, lenght);
            StringBuilder resultSb = new StringBuilder(result);
            return resultSb;
        }
    }
}
