namespace AnimalKingdom
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public enum Gender
    {
        Male, Female
    }

    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private Gender sex;

        public Animal(string name, int age, Gender sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;

        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                CheckName(value);
                this.name = value; 
            }
        }

        public int Age
        {
            get { return this.age; }
            private set { 
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be <0");
                }
                this.age = value; }
        }

        public Gender Sex
        {
            get { return this.sex; }
            set { this.sex = value; }
        }

        private void CheckName(string name)
        {
             if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Enter a name.");
            }
            foreach (char c in name)
            {
               if (!Char.IsLetter(c) && c != ' ' && c != '-')
               {
                   throw new ArgumentException("Invalid name!");
               }
            }
        }

        public abstract string Sound();

        public static double AverageAge(IEnumerable<Animal> animals)
        {
            return animals.Average(a => a.age);
        }
    }
}
