using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersAndStudents
{
    public class Student : Human
    {
        private double grade;

        public Student(string firstname, string lastname, double grade)
            :base (firstname, lastname)
        {
            this.Grade = grade;
        }

        public double Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }

        public override string ToString()
        {
            return this.Fullname + " - " + this.grade.ToString();
        }
    }
}
