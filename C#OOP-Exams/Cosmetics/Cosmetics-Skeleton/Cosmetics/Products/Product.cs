namespace Cosmetics.Products
{
    using System;

    using Cosmetics.Contracts;
    using Cosmetics.Common;
    using System.Text;

    public abstract class Product : IProduct
    {
        private const int MaximalNameLenght = 10;
        private const int MinimalProductNameLenght = 3;
        private const int MinimalBrandNameLenght = 2;

        private string name;
        private string brand;
        private GenderType gender;

        public decimal Price { get; protected set; }

        public Product(string name, string brand,decimal price,GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public Product(string name)
        {
            this.Name = name;
        }

        public Product()
        {

        }

        public virtual string Name
        {
            get { return this.name; }
            protected set
            {
                if (this.name.Length < MinimalProductNameLenght || this.name.Length > MaximalNameLenght)
                {
                    Console.WriteLine("Product name must be between {0} and {1} symbols long!",MinimalProductNameLenght,MaximalNameLenght);
                }

                else if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentNullException("Product must have a name!");
                }

                this.name = value;
            }
        }

        public string Brand
        {
            get { return this.brand; }
            protected set
            {
                
                if (this.brand.Length < MinimalBrandNameLenght || this.brand.Length > MaximalNameLenght)
                {
                    Console.WriteLine("Product brand must be between {0} and {1} symbols long!",MinimalBrandNameLenght,MaximalNameLenght);
                }
                
                else if (string.IsNullOrEmpty(brand))
                {
                    throw new ArgumentNullException("Brand must have a name!");
                }

                this.brand = value;
                
            }
        }

        public GenderType Gender 
        {
            get
            {
                return this.gender;
            }
            protected set
            {
                this.gender = value;
            }
        }

        public  string Print()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("- {0} - {1}:", this.Brand, this.Name).AppendLine();
            result.AppendFormat(" * Price: ${0}", this.Price).AppendLine();
            result.AppendFormat(" * For gender: {0}", this.Gender).AppendLine();

            return result.ToString().Trim();
        }
    }
}
