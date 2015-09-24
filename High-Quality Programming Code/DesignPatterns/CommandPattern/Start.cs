using CommandPattern.ConcreteCommand;
using CommandPattern.Invoker;
using CommandPattern.Reciever;
using System;

namespace CommandPattern
{
    class Start
    {
        static void Main()
        {
            //what is in da house
            Light bedroomLight = new Light();
            AirConditioner kitchenAC = new AirConditioner();

            RemoteController remote = new RemoteController();

            //on
            LightOn bedroomLightOn = new LightOn(bedroomLight);
            AirCondOn kitchenACOn = new AirCondOn(kitchenAC);

            //off
            LightOff bedroomLightOff = new LightOff(bedroomLight);
            AirCondOff kitchenACOff = new AirCondOff(kitchenAC);

            remote.InsertNewOnCommand(bedroomLightOn);
            remote.InsertNewOnCommand(kitchenACOn);
            remote.InsertNewOffCommand(bedroomLightOff);
            remote.InsertNewOffCommand(kitchenACOff);


            remote.pressON(0);
            remote.pressOFF(0);
            Console.Read();
        }
    }
}
