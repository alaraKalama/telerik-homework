## Command Pattern

Представлява обект, който енкапсулира цялата информация, необходима, за да се извика метод по-късно. Този пример работи с универсално дистанционно, което може да управлява всички уреди в един дом.
#####-Всяка команда е сама за себе си.
#####-Лесно добавяне на нови команди.

![Diagram](http://prikachi.com/images/157/8374157v.png)

###1. Abstract Command - ICommand
Има само един метод - execute()

```
public interface ICommand
```
###2. Reciever - уредите
Всеки уред, който може да бъде контролиран с това дистанционно се добавя тук като отделен клас. Лесно могат да се добавят или премахват уреди.

```
 public class Light
```
```
class AirConditioner
```
###3. ConcreteCommand
Всеки Reciever има команди. Всяка отделна команда се имплементира самостоятелно.

```
 class LightOn : ICommand
```

###4. Invoker - RemoteController
Обектът, който предизвиква командата.

```
public class RemoteController
```

###5. Client - where all should make sence 
####but still doesn't

```
static void Main()
```