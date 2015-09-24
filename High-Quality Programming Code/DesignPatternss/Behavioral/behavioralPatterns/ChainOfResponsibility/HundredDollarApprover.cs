namespace ChainOfResponsibility
{
    using System;

    /// <summary>
    /// the 'Concrete Handler'
    /// </summary>
    internal class HundredDollarApprover : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount >= 100.0)
            {
                var givenSum = 0;
                Console.WriteLine(
                    "{0} approved request for #{1} dollars",
                    this.GetType().Name, purchase.Amount);

                while (purchase.Amount >= 100)
                {
                    Console.WriteLine(
                   "┌───────────────────────────┐\n" +
                   "│ $                       $ │\n" +
                   "│                           │\n" +
                   "│            100            │\n" +
                   "│                           │\n" +
                   "│ $                       $ │\n" +
                   "└───────────────────────────┘");
                    purchase.Amount -= 100;
                    givenSum += 100;
                }
                Console.WriteLine("After giving {0} there are still {1} to give.", givenSum, purchase.Amount);
                Console.WriteLine("Processing request to {0}", this.Successor.GetType().Name);
                this.Successor.ProcessRequest(purchase);

            }
            else if (this.Successor != null)
            {
                this.Successor.ProcessRequest(purchase);
            }
        }
    }
}
