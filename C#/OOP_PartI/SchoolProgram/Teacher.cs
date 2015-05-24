

namespace SchoolProgram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Teacher : Person
    {
        private List<Discipline> disciplines;

        public Teacher(string firstname, string lastname, int age, List<Discipline> discipline)
            :base(firstname, lastname, age)
        {
            this.Disciplines = discipline.ToList();
        }

        public List<Discipline> Disciplines
        {
            get { return new List<Discipline> (this.disciplines); }
            set { this.disciplines = value; }
        }

        

        public void PrintDisciplines()
        {
            Console.WriteLine("{0} teaches:\n", this.FullName);
            foreach(Discipline disc in this.disciplines)
            {
                Console.WriteLine(disc.Name.ToString() + " for " + disc.Grade.ToString() + " grade");
            }
        }
    }
}
