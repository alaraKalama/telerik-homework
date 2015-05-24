using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersAndStudents
{
    public abstract class Human
    {
        private string firstname;
        private string lastname;
        private int age;

        public Human(string firstname, string lastname)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
        }

        public string Firstname
        {
            get { return this.firstname; }
            set
            {
                CheckName(value);
                this.firstname = value;
            }
        }

        public string Lastname
        {
            get { return this.lastname; }
            set
            {
                CheckName(value);
                this.lastname = value;

            }
        }

        public string Fullname
        {
            get { return Firstname + " " + Lastname; }
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
    }
}
