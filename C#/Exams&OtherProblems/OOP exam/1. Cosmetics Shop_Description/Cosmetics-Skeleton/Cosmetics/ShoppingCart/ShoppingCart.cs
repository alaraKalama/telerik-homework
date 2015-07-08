

namespace Cosmetics.ShoppingCart
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class ShoppingCart : IShoppingCart
    {
        public ICollection<IProduct> Products { get; private set; }

        public ShoppingCart()
        {
            this.Products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            this.Products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            this.Products.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            if(this.Products.Contains(product))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public decimal TotalPrice()
        {
            decimal result = 0;
            foreach(IProduct product in this.Products)
            {
                result += product.Price;
            }

            return result;
        }
    }
}
