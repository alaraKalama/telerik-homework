## Template Method

Този шаблон се използва когато имаме различни обекти, които в повечето случаи имат общо поведение, но в някои случаи то се различава. 
Хората например имат общо поведение - ядат, спят, ходят.
Различните хора обаче имат различна работа. С помощта на наследяване Template Method Pattern-a пренаписва поведението, което е различно при различните обекти (обикновенно абстрактен или виртуален метод).

###1. Базов абстрактен клас

Създаваме "алгоритъма" на поведение за човека - всичко, което е общо се имплементира, методът Work() - не.

```
public abstract class Person    {        protected Person(string fName, string lName)        {            this.FName = fName;            this.LName = lName;        }        protected string FName { get; private set; }        protected string LName { get; private set; }        public int Stamina { get; set; }        public double Money { get; set; }                public void Sleep()        {            this.Stamina += 30;            Console.WriteLine("{0} is sleeping", this.FName);            Console.WriteLine("{1}'s stamina is {0}", this.Stamina, this.FName);            Console.WriteLine("--------------------------------------------\n");        }        public abstract void Work();        public void Walk()        {            //logic        }        public void Eat()        {            //logic        }    }
```

###2. Наследници/Работници

Използването на този шаблон е смислено ако имаме два или повече обекта, които имат нужда от пренаписване на даден метод. Създаваме си класове Postman, Hairdresser, Developer, които се различават по начина на работа. 

```
class Postman : Person    {        public Postman(string fName, string lName)            : base(fName, lName)        {            this.Money = 100;            this.Stamina = 60;        }        public override void Work()        {            this.Money += 30;            this.Stamina -= 25;            Console.WriteLine("{0} is delivering mail", this.FName);            Console.WriteLine("{1}'s stamina is {0}", this.Stamina, this.FName);            Console.WriteLine("{1}'s money are {0}", this.Money, this.FName);            Console.WriteLine("--------------------------------------------\n");        }    }
    
class Developer : Person    {        public Developer(string fName, string lName)            : base(fName, lName)        {            this.Money = 1000;            this.Stamina = 50;        }        public override void Work()        {            this.Money += 150;            this.Stamina -= 40;            Console.WriteLine("{0} is making cool apps", this.FName);            Console.WriteLine("{1}'s stamina is {0}", this.Stamina, this.FName);            Console.WriteLine("{1}'s money are {0}", this.Money, this.FName);            Console.WriteLine("--------------------------------------------\n");        }   }
    
 class Hairdresser : Person    {        public Hairdresser(string fName, string lName)            : base(fName, lName)        {            this.Money = 300;            this.Stamina = 50;        }        public override void Work()        {            this.Money += 50;            this.Stamina -= 40;            Console.WriteLine("{0} made some nice haircuts", this.FName);            Console.WriteLine("{1}'s stamina is {0}", this.Stamina, this.FName);            Console.WriteLine("{1}'s money are {0}", this.Money, this.FName);            Console.WriteLine("--------------------------------------------\n");        }   }
```