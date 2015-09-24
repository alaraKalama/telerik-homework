namespace CommandPattern.ConcreteCommand
{
    using CommandPattern.AbstractCommand;
    using Reciever;

    class AirCondOn : ICommand
    {
        AirConditioner airCond;

        public AirCondOn(AirConditioner airCond)
        {
            this.airCond = airCond;
        }

        public void Execute()
        {
            airCond.IncreaseTemp();
            airCond.On();
        }
    }
}
