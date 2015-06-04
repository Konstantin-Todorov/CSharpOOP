using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    class ShoppingCart : Product , IShoppingCart
    {
        private IList<IProduct> products;

        public ShoppingCart()
        {

        }

        public void AddProduct(IProduct product)
        {
            this.products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            this.products.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            return products.Contains(product);
        }

        public decimal TotalPrice()
        {
            return this.TotalPrice();
        }
    }
}
