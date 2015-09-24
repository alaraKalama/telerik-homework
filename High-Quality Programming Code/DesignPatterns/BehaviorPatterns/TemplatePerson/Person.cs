namespace TemplateMethod
{
    using System;
    /// <summary>
    /// 'Abstract' base class
    /// </summary>
    public abstract class Person
    {
        protected Person(string fName, string lName)
        {
            this.FName = fName;
            this.LName = lName;

        }

        protected string FName { get; private set; }

        protected string LName { get; private set; }

        public int Stamina { get; set; }

        public double Money { get; set; }
        

        public void Sleep()
        {
            this.Stamina += 30;
            Console.WriteLine("{0} is sleeping", this.FName);
            Console.WriteLine("{1}'s stamina is {0}", this.Stamina, this.FName);
            Console.WriteLine("--------------------------------------------\n");
        }

        public abstract void Work();

        public void Walk()
        {
            this.Stamina -= 5;
            Console.WriteLine("{0} is walking", this.FName);
            Console.WriteLine("{1}'s stamina is {0}", this.Stamina, this.FName);
            Console.WriteLine("--------------------------------------------\n");
        }

        public void Eat()
        {
            this.Stamina += 10;
            this.Money -= 10;
            Console.WriteLine("{0} is eating", this.FName);
            Console.WriteLine("{1}'s stamina is {0}", this.Stamina, this.FName);
            Console.WriteLine("{1}'s money are {0}", this.Money, this.FName);
            Console.WriteLine("--------------------------------------------\n");
        }
    }
}
