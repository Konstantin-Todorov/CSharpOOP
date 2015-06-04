namespace Cosmetics.Products
{
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System.Text;

    public class Shampoo : Product , IShampoo ,IProduct
    {
        private UsageType usageType;

        public uint Milliliters { get; private set; }

        public Shampoo(string name, string brand, decimal price, GenderType gender,uint milliliters,UsageType usage)
            :base(name,brand,price,gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usageType;
        }

        public UsageType Usage
        {
            get
            {
                return this.usageType;
            }
            private set
            {
                this.usageType = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat(" * Quantity: {0} ml ", string.Join(", ", this.Milliliters)).AppendLine();
            result.AppendFormat(" * Usage: {0} ", this.Usage).AppendLine();


            return base.Print();

        }
    }
}
