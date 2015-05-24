

namespace SchoolProgram
{
    using System;
    using System.Collections.Generic;

    class Start
    {
        static void Main()
        {
            List<Grade> grades = new List<Grade>();
            CreateClasses(grades);
            School NGDEK = new School("NGDEK", grades);
            List<Discipline> Ogidisciplines = new List<Discipline>();
            Ogidisciplines.Add(new Discipline(DisciplineName.AncientGreek, DisciplineForGrade.Ninth, 3, 10));
            Ogidisciplines.Add(new Discipline(DisciplineName.History, DisciplineForGrade.Tenth, 1, 4));
            Teacher OgiRadev = new Teacher("Ognyan", "Radev", 150, Ogidisciplines);
            OgiRadev.PrintDisciplines();
            OgiRadev.OptionalComment = "This man drinks too much.";

            Student MariaNikolova = new Student("Maria", "Nikolova", 14, 8);
            MariaNikolova.Grade = grades[3];
            grades[3].AddStudent(MariaNikolova);
            Student GoshoPetrov = new Student("Gosho", "Petrov", 16, 10);
            Student PeterGeorgiev = new Student("Peter", "Petrov", 17, 11);
            Student GerganaZapryanova = new Student("Gergana", "Zapryanova", 18, 12);
            Student DonchoMinkov = new Student("Doncho", "Minkov", 13, 8);
            Student IvayloKenov = new Student("Ivaylo", "Kenov", 18, 12);
            Student ElinaElinova = new Student("Elina", "Elinova", 15, 9);
            grades[2].AddStudent(DonchoMinkov);
            grades[4].AddStudent(ElinaElinova);
            grades[10].AddStudent(GoshoPetrov);
            grades[13].AddStudent(PeterGeorgiev);
            grades[17].AddStudent(GerganaZapryanova);
            grades[17].AddStudent(IvayloKenov);
        }

        private static void CreateClasses(List<Grade> grades)
        {
            Grade eightA = new Grade(10, ClassIdentifier.A);
            Grade eightB = new Grade(10, ClassIdentifier.B);
            Grade eightC = new Grade(10, ClassIdentifier.C);
            Grade eightD = new Grade(10, ClassIdentifier.D);

            Grade ninthA = new Grade(9, ClassIdentifier.A);
            Grade ninthB = new Grade(9, ClassIdentifier.B);
            Grade ninthC = new Grade(9, ClassIdentifier.C);
            Grade ninthD = new Grade(9, ClassIdentifier.D);

            Grade tenthA = new Grade(10, ClassIdentifier.A);
            Grade tenthB = new Grade(10, ClassIdentifier.B);
            Grade tenthC = new Grade(10, ClassIdentifier.C);
            Grade tenthD = new Grade(10, ClassIdentifier.D);

            Grade eleventhA = new Grade(11, ClassIdentifier.A);
            Grade eleventhB = new Grade(11, ClassIdentifier.B);
            Grade eleventhC = new Grade(11, ClassIdentifier.C);
            Grade eleventhD = new Grade(11, ClassIdentifier.D);

            Grade twelfthA = new Grade(12, ClassIdentifier.A);
            Grade twelfthB = new Grade(12, ClassIdentifier.B);
            Grade twelfthC = new Grade(12, ClassIdentifier.C);
            Grade twelfthD = new Grade(12, ClassIdentifier.D);

            grades.Add(eightA);
            grades.Add(eightB);
            grades.Add(eightC);
            grades.Add(eightD);
            grades.Add(ninthA);
            grades.Add(ninthB);
            grades.Add(ninthC);
            grades.Add(ninthD);
            grades.Add(tenthA);
            grades.Add(tenthB);
            grades.Add(tenthC);
            grades.Add(tenthD);
            grades.Add(eleventhA);
            grades.Add(eleventhB);
            grades.Add(eleventhC);
            grades.Add(eleventhD);
            grades.Add(twelfthA);
            grades.Add(twelfthB);
            grades.Add(twelfthC);
            grades.Add(twelfthD);
        }
    }
}
