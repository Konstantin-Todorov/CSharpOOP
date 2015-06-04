namespace FurnitureManufacturer.Models
{
    using System;

    using FurnitureManufacturer.Interfaces;

    public abstract class Furniture : IFurniture
    {
        private string model;
        private decimal price;
        private decimal height;

        protected MaterialType MaterialType { get; set; }

        public virtual string Material
        {
            get
            {
                return this.MaterialType.ToString();
            }
        }

        public virtual string Model
        {
            get { return this.model; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model cannot be empty or null");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentNullException("Model cannot be with less than 3 symbols");
                }
                this.model = value;
            }
        }

        public virtual decimal Price
        {
             get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Price cannot be less or equal to null");
                }
                this.price = value; 
            }
        }

        public virtual decimal Height
        {
            get { return this.height; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Height cannot be less or equal to null");
                }
                this.height = value;
            }
        }
    }
}
