namespace TemplateMethod
{
    using System;

    class Developer : Person
    {
        public Developer(string fName, string lName)
            : base(fName, lName)
        {
            this.Money = 1000;
            this.Stamina = 50;
        }


        public override void Work()
        {
            this.Money += 150;
            this.Stamina -= 40;
            Console.WriteLine("{0} is making cool apps", this.FName);
            Console.WriteLine("{1}'s stamina is {0}", this.Stamina, this.FName);
            Console.WriteLine("{1}'s money are {0}", this.Money, this.FName);
            Console.WriteLine("--------------------------------------------\n");
        }

    }
}
