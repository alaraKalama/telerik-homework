namespace CommandPattern.ConcreteCommand
{
    using System;
    using CommandPattern.AbstractCommand;
    using CommandPattern.Reciever;

    class LightOn : ICommand
    {
        Light light;

        public LightOn(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.On();
        }
    }
}
