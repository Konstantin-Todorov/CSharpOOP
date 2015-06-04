namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System.Text;

    public class Table : Furniture , ITable
    {
        private decimal length;
        private decimal width;

        public Table(string model, MaterialType materialType, decimal price, decimal height, decimal length, decimal width)
        {
            this.Model = model;
            this.MaterialType = materialType;
            this.Price = price;
            this.Height = height;
            this.Length = length;
            this.Width = width;
        }

        public decimal Length
        {
            get {return this.length ;}
            private set { this.length = value; }
        }

        public decimal Width
        {
            get { return this.width; }
            private set { this.width = value; }
        }

        public decimal Area
        {
            get { return this.Length * this.Width; }
        }

        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Length: {5}, Width: {6}, Area: {7}",
                this.GetType().Name, this.Model, this.MaterialType, this.Price, this.Height, this.Length, this.Width, this.Area);
        }
    }
}
