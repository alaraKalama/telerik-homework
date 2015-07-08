namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public class Shampoo : Product, IShampoo
    {
        private uint milliliters;
        private UsageType usage;


        public Shampoo(string name, string brand, decimal price, GenderType genderType, uint ml, UsageType usage)
            :base(name, brand, price, genderType)
        {
            this.Milliliters = ml;
            this.Usage = usage;
        }


        public uint Milliliters
        {
            get { return this.milliliters; }
            private set 
            {
                ValidatorAdditional.ValidateMilliliters(value);
                this.milliliters = value;
            }
        }

        public UsageType Usage
        {
            get { return this.usage; }
            private set
            {
                Validator.CheckIfNull(value, GlobalErrorMessages.ObjectCannotBeNull);
                this.usage = value;
            }
        }

        public override string Print()
        {
            var result = new StringBuilder();
            result.Append(base.Print());
            result.AppendLine(String.Format("  * Quantity: {0} ml", this.Milliliters));
            result.Append(String.Format("  * Usage: {0}", this.Usage.GetType().ToString()));
            return result.ToString();
        }
    }
}
