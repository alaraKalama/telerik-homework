## Command Pattern

Представлява обект, който енкапсулира цялата информация, необходима, за да се извика метод по-късно. Този пример работи с универсално дистанционно, което може да управлява всички уреди в един дом.
#####-Всяка команда е сама за себе си.
#####-Лесно добавяне на нови команди.

![Diagram](http://prikachi.com/images/157/8374157v.png)

###1. Abstract Command - ICommand
Има само един метод - execute()

```
public interface ICommand    {        void Execute();    }
```
###2. Reciever - уредите
Всеки уред, който може да бъде контролиран с това дистанционно се добавя тук като отделен клас. Лесно могат да се добавят или премахват уреди.

```
 public class Light    {        public void On()        {            Console.WriteLine("Lights are on!");        }        public void Off()        {            Console.WriteLine("Lights are off");        }    }
```
```
class AirConditioner    {        public void On()        {            Console.WriteLine("AirCon is on!");        }        public void Off()        {            Console.WriteLine("AirCon is off");        }        public void IncreaseTemp()        {            Console.WriteLine("Increasing temp");        }        public void DecreaseTemp()        {            Console.WriteLine("Decreasing temp");        }    }
```
###3. ConcreteCommand
Всеки Reciever има команди. Всяка отделна команда се имплементира самостоятелно.

```
 class LightOn : ICommand    {        Light light;        public LightOn(Light light)        {            this.light = light;        }        public void Execute()        {            light.On();        }    }
```

###4. Invoker - RemoteController
Обектът, който предизвиква командата.

```
public class RemoteController    {        private IList<ICommand> turnOnCommands = new List<ICommand>();        private IList<ICommand> turnOffCommands = new List<ICommand>();        public void InsertNewOnCommand(ICommand onCommand)        {            turnOnCommands.Add(onCommand);        }        public void InsertNewOffCommand(ICommand offCommand)        {            turnOffCommands.Add(offCommand);        }        public void pressON(int btnNumber)        {            turnOnCommands[btnNumber].Execute();        }        public void pressOFF(int btnNumber)        {            turnOffCommands[btnNumber].Execute();        }    }
```

###5. Client - where all should make sence 
####but still doesn't

```
static void Main()        {            //what is in da house            Light bedroomLight = new Light();            AirConditioner kitchenAC = new AirConditioner();            RemoteController remote = new RemoteController();            //on            LightOn bedroomLightOn = new LightOn(bedroomLight);            AirCondOn kitchenACOn = new AirCondOn(kitchenAC);            //off            LightOff bedroomLightOff = new LightOff(bedroomLight);            AirCondOff kitchenACOff = new AirCondOff(kitchenAC);            remote.InsertNewOnCommand(bedroomLightOn);            remote.InsertNewOnCommand(kitchenACOn);            remote.InsertNewOffCommand(bedroomLightOff);            remote.InsertNewOffCommand(kitchenACOff);            remote.pressON(0);            remote.pressOFF(0);            remote.pressON(1);            Console.Read();        }
```
