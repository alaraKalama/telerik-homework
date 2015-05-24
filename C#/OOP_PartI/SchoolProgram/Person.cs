
namespace SchoolProgram
{
    using System;

    public class Person
    {
        //fields:
        private string firstname;
        private string lastname;
        private int age;
        private string optionalComment;

        //constructor:
        public Person(string firstname, string lastname, int age)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Age = age;
        }

        public Person(string firstname, string lastname, int age, string comment)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Age = age;
            this.OptionalComment = comment;
        }

        //properties:
        public string FirstName
        {
            get { return this.firstname; }
            set
            {
                CheckName(value);
                this.firstname = value; 
            }
        }

        public string LastName
        {
            get { return this.lastname; }
            set
            {
                CheckName(value);
                this.lastname = value; 
            }
        }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                CheckAge(value);
                this.age = value;
            }
        }

        public string OptionalComment
        {
            get
            {
                if (String.IsNullOrWhiteSpace(optionalComment))
                {
                    return "There is no comment on this person.";
                }
                return this.optionalComment;
            }
            set { this.optionalComment = value; }
        }

        //methods:
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

        private void CheckAge(int age)
        {
            if (age <= 0)
            {
                throw new ArgumentNullException("The people in this school should be born to teach or study.");
            }
        }
    }
}
