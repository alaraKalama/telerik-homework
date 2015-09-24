namespace CommandPattern.ConcreteCommand
{
    using System;
    using CommandPattern.AbstractCommand;
    using Reciever;

    class AirCondOff : ICommand
    {
        AirConditioner airCond;

        public AirCondOff(AirConditioner airCond)
        {
            this.airCond = airCond;
        }

        public void Execute()
        {
            airCond.DecreaseTemp();
            airCond.Off();
        }
    }
}
