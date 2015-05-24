

namespace SchoolProgram
{

    
    public class Student : Person
    {
        private int classNumber;
        private Grade grade;

        public Student(string firstname, string lastname, int age, int classNumber)
            :base (firstname, lastname, age)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get { return this.classNumber; }
            set { this.classNumber = value; }
        }

        public Grade Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }
    }
}
