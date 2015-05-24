namespace AnimalKingdom
{
    using System;
    using System.Collections.Generic;
    
    class Start
    {
        static void Main(string[] args)
        {
            Dog Rocky = new Dog("Rocky", 6, Gender.Male);
            Cat Shiva = new Cat("Shiva", 4, Gender.Female);
            Tomcat Maroicho = new Tomcat("Maroicho", 3);
            Frog Kermit = new Frog("Kermit", 4, Gender.Male);
            Fox Foxy = new Fox("Foxy", 6, Gender.Female);
            Console.WriteLine("Shiva says: {0}", Shiva.Sound());
            Console.WriteLine("Rocky says: {0}", Rocky.Sound());
            Console.WriteLine("Maroicho says: {0}", Maroicho.Sound());
            Console.WriteLine("Kermit says: {0}", Kermit.Sound());
            Console.WriteLine("What does the fox say? {0}", Foxy.Sound());
            List<Animal> animals = new List<Animal>() { Rocky, Maroicho, Shiva, Kermit, Foxy };
            Console.WriteLine("Average age of the animals: {0}", Animal.AverageAge(animals));
            Animal[] cats = new Cat[]{new Cat("Pisana", 5, Gender.Female), new Cat("Tom", 2, Gender.Male), 
                new Kitten("Maca", 1), new Tomcat("Tiger", 4, Gender.Male), new Cat("Spas", 5, Gender.Male), Maroicho, Shiva};
            Animal[] dogs = new Dog[]{new Dog("Alem", 9, Gender.Male), new Dog("Raiko", 3, Gender.Male), new Dog("Dita", 4, Gender.Female), 
                new Dog("Amarok", 5, Gender.Male), new Dog("Aza", 9, Gender.Female), Rocky};
            Animal[] frogs = new Frog[]{new Frog("Jabcho", 2, Gender.Male), new Frog("Jaborana", 3, Gender.Female), new Frog("Kvak", 7, Gender.Male),
                new Frog("Gruh", 5, Gender.Male), Kermit};
            Console.WriteLine("Average age of cats: {0:F2}", Animal.AverageAge(cats));
            Console.WriteLine("Average age of dogs: {0}", Animal.AverageAge(dogs));
            Console.WriteLine("Average age of frogs: {0}", Animal.AverageAge(frogs));


        }
    }
}
