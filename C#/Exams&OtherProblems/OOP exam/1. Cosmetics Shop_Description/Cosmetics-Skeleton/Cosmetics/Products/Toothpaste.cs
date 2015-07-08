namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Toothpaste : Product , IToothpaste
    {
        private string ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, ICollection<string> ingredients)
            :base(name, brand, price, gender)
        {
            this.Ingredients = ingredientsToSingleString(ingredients);
        }

        public string Ingredients 
        {
            get { return this.ingredients; }
            private set
            {
                Validator.CheckIfNull(value);
                ValidatorAdditional.ValidateIngredients(value);
                this.ingredients = value;
            }
        }

        private static string ingredientsToSingleString(ICollection<string> ingredients)
        {
            var result = String.Join(",", ingredients.Select(i => i.ToString()));
            return result;
        }

        public override string Print()
        {
            var result = new StringBuilder();
            result.Append(base.Print());
            result.Append(String.Format("  * Ingredients: {0}", this.Ingredients));
            return result.ToString();
        }
    }
}
