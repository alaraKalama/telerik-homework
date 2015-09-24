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
 public interface IPostOffice    {        void addMailBox(IObserver o);        void removeMailBox(IObserver o);        void notifyMailBox();    }
    
    public interface IObserver    {        void Update();    }
```

###2. Субектът
Независимата функционалност на пощата се имплементира в един клас, наследник на IPostOffice

```
public class PostOffice : IPostOffice    {        private string Address;        private List<IObserver> mailBoxes;        public PostOffice(string address)        {            this.Address = address;            mailBoxes = new List<IObserver>();        }        public void addMailBox(IObserver mailBox)        {            this.mailBoxes.Add(mailBox);        }        public void notifyMailBox()        {            foreach(var mailBox in this.mailBoxes)            {                mailBox.Update();            }        }        public void removeMailBox(IObserver mailBox)        {            this.mailBoxes.Remove(mailBox);        }    }
```

###3. Наблюдаващите

Пощенската кутия е само една имплементация на IObserver. Друга може да бъде OwlMail например. Важното е, че PostOffice е обвързан единствено с IObserver.

```
 public class MailBox : IObserver    {        public string Name;        public MailBox(string name)        {            this.Name = name;        }        public void Update()        {            Console.WriteLine("New Mail for {0}", this.Name);        }    }
```


 
 inspired by [this](https://www.youtube.com/watch?v=rWvXJo3OAzs).