
namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public abstract class Product : IProduct
    {
        private string name;
        private string brand;
        private decimal price;
        private GenderType genderType;

        public Product(string name, string brand, decimal price, GenderType genderType)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = genderType;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value,
                    String.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Product name"));
                Validator.CheckIfStringLengthIsValid(value, 
                    GlobalConstants.maxProductNameLenght,
                    GlobalConstants.minBrandNameLenght, 
                    String.Format(GlobalErrorMessages.InvalidStringLength, 
                    "Product name", GlobalConstants.minProductNameLenght, GlobalConstants.maxProductNameLenght));

                this.name = value;
            }
        }

        public string Brand
        {
            get { return this.brand; }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value,
                   String.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Product brand"));
                Validator.CheckIfStringLengthIsValid(value,
                    GlobalConstants.maxBrandNameLenght,
                    GlobalConstants.minBrandNameLenght,
                    String.Format(GlobalErrorMessages.InvalidStringLength,
                    "Product brand", GlobalConstants.minBrandNameLenght, GlobalConstants.maxBrandNameLenght));

                this.brand = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            private set
            {
                ValidatorAdditional.ValidatePrice(value); // ??
                this.price = value; 
            }
        }

        public Common.GenderType Gender
        {
            get { return this.genderType; }
            set 
            {
                Validator.CheckIfNull(value, String.Format(GlobalErrorMessages.ObjectCannotBeNull, "Gender type"));
                this.genderType = value; 
            }
        }

        public virtual string Print()
        {
            var result = new StringBuilder();
            result.AppendLine(String.Format("- {0} – {1}:", this.Brand, this.Name));
            result.AppendLine(String.Format("  * Price: ${0}", this.Price));
            result.AppendLine(String.Format("  * For gender: {0}", this.Gender.GetType().ToString()));
            return result.ToString();
        }
    }
}
