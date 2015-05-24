

namespace SchoolProgram
{
    using System;
    using System.Collections.Generic;

    public enum ClassIdentifier
    {
        A, B, C, D
    }
    public class Grade
    {
        private int yearGrade;
        private ClassIdentifier identifier;
        private List<Student> studentsInClass;
        private string optionalComment;

        public Grade(int yearGrade, ClassIdentifier id, List<Student> studentsInClass)
        {
            this.YearGrade = yearGrade;
            this.Identifier = id;
            this.StudentsInClass = studentsInClass;
        }

        public Grade(int yearGrade, ClassIdentifier id)
        {
            this.YearGrade = yearGrade;
            this.Identifier = id;
            this.StudentsInClass = new List<Student>();
        }

        public int YearGrade
        {
            get { return this.yearGrade; }
            set 
            {
                this.yearGrade = value; 
            }
        }

        public ClassIdentifier Identifier
        {
            get { return this.identifier; }
            set { this.identifier = value; }
        }

        public List<Student> StudentsInClass
        {
            get { return this.studentsInClass; }
            set { this.studentsInClass = value; }
        }

        public string OptionalComment
        {
            get
            {
                if (String.IsNullOrWhiteSpace(optionalComment))
                {
                    return "no comment";
                }
                return this.optionalComment;
            }
            set { this.optionalComment = value; }
        }

        public void AddStudent(Student student)
        {
            this.studentsInClass.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.studentsInClass.Remove(student);
        }

        

    }
}
