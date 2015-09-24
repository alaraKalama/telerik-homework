namespace CommandPattern.ConcreteCommand
{
    using System;
    using CommandPattern.AbstractCommand;
    using CommandPattern.Reciever;

    class LightOff : ICommand
    {
        Light light;

        public LightOff(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.Off();
        }
    }
}