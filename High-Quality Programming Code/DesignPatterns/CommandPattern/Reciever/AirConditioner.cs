namespace CommandPattern.Reciever
{
    using System;
    class AirConditioner
    {
        public void On()
        {
            Console.WriteLine("AirCon is on!");
        }
        public void Off()
        {
            Console.WriteLine("AirCon is off");
        }
        public void IncreaseTemp()
        {
            Console.WriteLine("Increasing temp");
        }
        public void DecreaseTemp()
        {
            Console.WriteLine("Decreasing temp");
        }

    }
}
