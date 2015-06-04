namespace FurnitureManufacturer.Models
{
    using Interfaces;
    using Models;

    public class ConvertibleChair : Chair , IConvertibleChair
    {
        private bool isConverted = false;

        public ConvertibleChair(string model, Models.MaterialType materialType, decimal price, decimal height, int numberOfLegs)
            :base(model,materialType,price,height,numberOfLegs)
        {
        }
        public bool IsConverted
        {
            get { return this.isConverted; }
        }

        public void Convert()
        {
            this.isConverted = !isConverted;
        }

        public override decimal Height
        {
            get
            {
                if (this.isConverted)
                {
                    return 0.10m;
                }
                else
                {
                    return base.Height;
                }
            }
            protected set
            {
                base.Height = value;
            }
        }
        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}, State: {6}",
                this.GetType().Name, this.Model, this.MaterialType, this.Price, this.Height, this.NumberOfLegs, this.IsConverted ? "Converted" : "Normal");
        }
    }
}
