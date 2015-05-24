

namespace SchoolProgram
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private string name;
        private List<Grade> grades;

        public School(string name, List<Grade> grades)
        {
            this.Name = name;
            this.Grades = grades;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public List<Grade> Grades
        {
            get { return this.grades; }
            set { this.grades = value; }
        }
    }
}
