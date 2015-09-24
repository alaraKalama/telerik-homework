## The Observer Pattern

Този шаблон дефинира вазимовръзка между един обект и зависещите от него, които са уведомени когато обектът промени състоянието си. 

Общите компоненити се енкапсулират в абстракция на обекта (IPostOffice), а променливите компоненти(mail boxes) в йерархия от наблюдатели(IObserver). 

###Обектът не знае за конкретни "наблюдаващи го".

 ![Class Diagram](http://prikachi.com/images/881/8373881p.png)
 
###1. Зависимост

Пощата е обектът, който може да добавя/премахва нови пощенски кутии. (addMailBox/RemoveMailBox)
Когато има ново писмо - уведомява всички, които я наблюдават.(notifyMailBox)
Пощенската кутия от друга страна има само един метод - Update(), който пряко зависи от Пощата.

```
 public interface IPostOffice
    
    public interface IObserver
```

###2. Субектът
Независимата функционалност на пощата се имплементира в един клас, наследник на IPostOffice

```
public class PostOffice : IPostOffice
```

###3. Наблюдаващите

Пощенската кутия е само една имплементация на IObserver. Друга може да бъде OwlMail например. Важното е, че PostOffice е обвързан единствено с IObserver.

```
 public class MailBox : IObserver
```


 
 inspired by [this](https://www.youtube.com/watch?v=rWvXJo3OAzs).