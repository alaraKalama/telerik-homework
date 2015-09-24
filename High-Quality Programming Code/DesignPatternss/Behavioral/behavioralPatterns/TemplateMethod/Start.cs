namespace TemplateMethod
{
    using System;

    class Start
    {
        static void Main()
        {
            Person jorko = new Hairdresser("Jorko", "Friziorko");
            Person doncho = new Developer("Doncho", "Minkov");
            Person peyo = new Postman("Peyo", "Poshtalyona");

            jorko.Walk();
            jorko.Eat();
            peyo.Sleep();
            doncho.Walk();
            doncho.Work();
            doncho.Sleep();
            doncho.Eat();
            jorko.Work();
            peyo.Work();

            Console.ReadLine();


        }
    }
}