namespace TemplateMethod
{
    using System;

    class Postman : Person
    {
        public Postman(string fName, string lName)
            : base(fName, lName)
        {
            this.Money = 100;
            this.Stamina = 60;
        }
        

        public override void Work()
        {
            this.Money += 30;
            this.Stamina -= 25;
            Console.WriteLine("{0} is delivering mail", this.FName);
            Console.WriteLine("{1}'s stamina is {0}", this.Stamina, this.FName);
            Console.WriteLine("{1}'s money are {0}", this.Money, this.FName);
            Console.WriteLine("--------------------------------------------\n");
        }

    }
}
