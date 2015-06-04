using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    class Category : Product , ICategory , IProduct
    {
        private const int MinimumCategoryNameLength = 2;
        private const int MaximumCategoryNameLength = 15;
        private IList<IProduct> cosmetic;
        private string name;

        public Category(string name)
            :base(name)
        {
            this.Name = name;
        }

        public override string Name
        {
            get
            {
                return base.Name;
            }
            protected set
            {
                
                if (this.name.Length < MinimumCategoryNameLength || this.name.Length > MaximumCategoryNameLength)
                {
                    Console.WriteLine("Category name must be between {0} and {1} symbols long!", MinimumCategoryNameLength, MaximumCategoryNameLength);
                }
                else if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentNullException("Category must have a name!");
                }
                this.name = value;
                
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            this.cosmetic.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
             if (!cosmetic.Contains(cosmetics))
            {
                Console.WriteLine("Product {0} does not exist in category {0}!", base.Name, this.Name);
            }
            else
            {
                this.cosmetic.Remove(cosmetics);
           }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("{0} category - {1} products/product in total", this.Name, this.cosmetic.Count).AppendLine();

            return base.Print();
        }
    }
}
