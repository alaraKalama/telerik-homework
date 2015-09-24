namespace TemplateMethod
{
    using System;

    class Hairdresser : Person
    {
        public Hairdresser(string fName, string lName)
            : base(fName, lName)
        {
            this.Money = 300;
            this.Stamina = 50;
        }

        public override void Work()
        {
            this.Money += 50;
            this.Stamina -= 40;
            Console.WriteLine("{0} made some nice haircuts", this.FName);
            Console.WriteLine("{1}'s stamina is {0}", this.Stamina, this.FName);
            Console.WriteLine("{1}'s money are {0}", this.Money, this.FName);
            Console.WriteLine("--------------------------------------------\n");
        }


    }
}
