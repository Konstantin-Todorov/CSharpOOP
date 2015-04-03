
namespace RangeException.Exception
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class InvalidRangeException<T> : ApplicationException
    {
        private T startRange;
        private T endRange;

        public InvalidRangeException(string message,T startRange,T endRange,Exception ex)
            :base(message,ex)
        {
            this.StartRange = startRange;
            this.EndRange = endRange;
        }

        public InvalidRangeException(string message, T startRange, T endRange)
            : this(message,startRange,endRange,null)
        {
            this.StartRange = startRange;
            this.EndRange = endRange;
        }

        public T EndRange
        {
            get { return this.endRange; }
            set { this.endRange = value; }
        }
        

        public T StartRange
        {
            get { return this.startRange; }
            set { this.startRange = value; }
        }
        
    }
}
