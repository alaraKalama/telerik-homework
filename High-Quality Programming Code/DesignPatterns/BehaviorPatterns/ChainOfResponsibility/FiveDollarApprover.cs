namespace ChainOfResponsibilityATM
{
    using System;

    /// <summary>
    /// the 'Concrete Handler'
    /// </summary>
    internal class FiveDollarApprover : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount >= 5.0)
            {
                var givenSum = 0;
                Console.WriteLine(
                    "{0} approved request for #{1} dollars",
                    this.GetType().Name, purchase.Amount);

                while (purchase.Amount >= 5)
                {
                    Console.WriteLine(
                   "┌───────────────────────────┐\n" +
                   "│ $                       $ │\n" +
                   "│                           │\n" +
                   "│            5              │\n" +
                   "│                           │\n" +
                   "│ $                       $ │\n" +
                   "└───────────────────────────┘");
                    purchase.Amount -= 5;
                    givenSum += 5;
                }
                Console.WriteLine("After giving {0} there are still {1} to give.", givenSum, purchase.Amount);
            }
            else
            {
                Console.WriteLine("{0} can't handle this request. ATM can't give less than 5 dollars");
            }
        }
    }
}
