namespace ChainOfResponsibilityATM
{
    using System;

    class Start
    {
        static void Main()
        {
            Approver hundred = new HundredDollarApprover();
            Approver fifty = new FiftyDollarApprover();
            Approver twenty = new TwentyDollarApprover();
            Approver ten = new TenDollarApprover();
            Approver five = new FiveDollarApprover();

            hundred.setSuccessor(fifty);
            fifty.setSuccessor(twenty);
            twenty.setSuccessor(ten);
            ten.setSuccessor(five);

            Console.WriteLine("Please, enter the amount of money you like to withdraw:");
            var amount = double.Parse(Console.ReadLine());
            var purchase = new Purchase(amount);
            hundred.ProcessRequest(purchase);

            Console.ReadLine();
        }
    }
}
