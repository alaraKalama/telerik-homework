
namespace Cosmetics.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Cosmetics.Common;

    public static class ValidatorAdditional
    {
        public static void ValidatePrice(decimal price, string message = null)
        {
            if (price <= 0)
            {
                throw new ArgumentException(message);
            }
        }

        public static void ValidateMilliliters(uint ml, string message = null) //add new class with error messages
        {
            if(ml <= 0)
            {
                throw new ArgumentException(message);
            }
        }

        public static void ValidateIngredients(string ingredients, string message = null)
        {
            string[] ingredientsToArray = ingredients.Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries);

            foreach(string ingredient in ingredientsToArray)
            {
                Validator.CheckIfStringLengthIsValid(
                    ingredient,
                    GlobalConstants.maxIngredientLenght,
                    GlobalConstants.minIngredientsLenght,
                    String.Format(GlobalErrorMessages.InvalidStringLength)); //placeholders!
            }
        }
    }
}
