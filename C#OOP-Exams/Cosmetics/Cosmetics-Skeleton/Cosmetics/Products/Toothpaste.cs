namespace Cosmetics.Products
{
    using Cosmetics.Common;
    using Cosmetics.Contracts;

    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Toothpaste : Product, IToothpaste, IProduct
    {
        private const int MinimalIngridiantsNameLenght = 4;
        private const int MaximalIngridiantsNameLenght = 12;

        private ICollection<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.ingredients = new List<string>();
        }

        public string Ingredients
        {
            get;
            private set;
            //{
            //    if (value == null)
            //    {
            //        throw new ArgumentNullException("Ingridiants must have a name!");
            //    }
            //    else if (this.ingredients.Count < MinimalIngridiantsNameLenght)
            //    {
            //        Console.WriteLine("Each ingredient must be between 4 and 12 symbols long!");
            //    }
            //    else if (this.ingredients.Count > MaximalIngridiantsNameLenght)
            //    {
            //        Console.WriteLine("Each ingredient must be between 4 and 12 symbols long!");
            //    }
            //    else
            //    {
            //        this.ingredients = value;
            //    }
            //}
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat(" * Ingredients: {0}", string.Join(", ",this.Ingredients)).AppendLine();

            return base.Print();

        }
    }
}
