namespace ChainOfResponsibility
{
    /// <summary>
    /// The 'handler' abstract class
    /// </summary>
    internal abstract class Approver
    {
        protected Approver Successor { get; set; }

        public void setSuccessor(Approver successor)
        {
            this.Successor = successor;
        }

        public abstract void ProcessRequest(Purchase purchase);
    }
}
