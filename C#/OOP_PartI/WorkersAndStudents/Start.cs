using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersAndStudents
{
    class Start
    {
        static void Main()
        {

            Worker[] workers = new Worker[]
            {
                new Worker("Ivaylo", "Kenov", 2000m, 8),
                new Worker("Debel", "Bakshish", 50m, 8),
                new Worker("Violeta", "Petrova", 133.67m, 8),
                new Worker("Gergana", "Nedyalkova", 400m, 4),
                new Worker("Peter", "Georgiev", 200m, 8),
                new Worker("Bilyana", "Georgieva", 100m, 8),
                new Worker("Miro", "Yordanov", 345.89m, 8),
                new Worker("Daniela", "Petrova", 130.50m, 8),
                new Worker("George", "Nedyalkov", 400m, 7),
                new Worker("Veselin", "Nedyalkov", 250.78m, 5)
            };

            Student[] students = new Student[]
            {
                new Student("Misho", "Stoyanov", 4),
                new Student("Venera", "Petrova", 6),
                new Student("Peter", "Evtimov", 3),
                new Student("Mila", "Georgieva", 6),
                new Student("Alexander", "Hinov", 6),
                new Student("Bianca", "Uzunova", 5.50),
                new Student("Todor", "Todorov", 4),
                new Student("Mihail", "Petrov", 2),
                new Student("Elina", "Savova", 4),
                new Student("Maria", "Ilinchina", 3.50)
            };
            Console.WriteLine("Students sorted by grade: \n{0}", String.Join("\n", listOfGrades(students)));
            Console.WriteLine();
            Console.WriteLine("Workers sorted by money/hour : \n{0}", String.Join("\n", listOfMoneyPerHour(workers)));

            var allPeople = MergeLists(students, workers);
            Console.WriteLine();
            Console.WriteLine("All people sorted by first, then by lastnames: \n{0}", String.Join("\n", SortByName(allPeople)));
            
        }

        private static IEnumerable<Student> listOfGrades(Student[] students)
        {
            return from student in students
                   orderby student.Grade
                   select student;
        }

        private static IEnumerable<Worker> listOfMoneyPerHour (Worker[] workers)
        {
           // return from worker in workers
             //      orderby worker.MoneyPerHour() descending
               //    select worker;
            return workers.OrderByDescending(w => w.MoneyPerHour());
        }

        private static List<Human> MergeLists(Student[] students, Worker[] workers)
        {
            var allPeople = new List<Human>(students.Length + workers.Length);
            allPeople.AddRange(students);
            allPeople.AddRange(workers);
            return allPeople;
        }

        private static IEnumerable<String> SortByName(List<Human> people)
        {
            return from person in people
                   orderby person.Firstname
                   orderby person.Lastname
                   select person.Fullname.ToString();
        }
    }
}
