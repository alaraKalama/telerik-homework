
namespace Cosmetics.Categories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Category : ICategory
    {
        private string name;
        private ICollection<IProduct> products;

        public Category(string name)
        {
            this.Name = name;
            this.Products = new List<IProduct>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value);
                Validator.CheckIfStringLengthIsValid(value, 
                    GlobalConstants.maxCategoryNameLenght, 
                    GlobalConstants.minCategoryNameLenght, 
                    String.Format(GlobalErrorMessages.InvalidStringLength, 
                    "Category name", GlobalConstants.minCategoryNameLenght, GlobalConstants.maxCategoryNameLenght));

                this.name = value;
            }
        }

        public ICollection<IProduct> Products
        {
            get { return this.products; }
            private set
            {
                Validator.CheckIfNull(value);
                this.products = value;
            }

        }

        public void AddCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics);
            this.Products.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics);
            this.Products.Remove(cosmetics);
        }

        public string Print()
        {
            var result = new StringBuilder();
            if(this.Products.Count > 1)
                result.AppendLine(String.Format("{0} category – {1} products in total", this.Name, this.Products.Count.ToString()));

            if (this.Products.Count == 1)
                result.AppendLine(String.Format("{0} category – {1} product in total", this.Name, "1"));

            if (this.Products.Count < 1)
                result.AppendLine(String.Format("{0} category – {1} products in total", this.Name, "0"));

            foreach(IProduct product in this.Products)
            {
                result.Append(product.Print());
            }

            return result.ToString();
        }
    }
}
