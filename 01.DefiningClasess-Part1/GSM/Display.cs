
namespace GSM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Display
    {
        private double? displaySize;
        private long numberOfColors;

        public Display(double? displaySize, long numberOfColors)
        {
            this.Size = displaySize;
            this.numberOfColors = Colors;
        }

        public double? Size
        {
            get { return this.displaySize; }
            set { this.displaySize = value; }
        }

        public long Colors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }
    }
}
