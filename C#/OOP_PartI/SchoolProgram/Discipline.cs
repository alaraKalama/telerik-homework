

namespace SchoolProgram
{
    using System;

    public enum DisciplineName
    {
        Mathematics, Physics, Chemistry, ComputerScience, Art, Biology, History, Psyhology, Sport, Literature, Latin, English, Geography, 
        AncientGreek, Phylosophy, German, French

    }
    public enum DisciplineForGrade
    {
        Eight, Ninth, Tenth, Eleventh, Twelfth
    }
    public class Discipline
    {
        //fields:
        private DisciplineName name;
        private DisciplineForGrade grade;
        private int lectures;
        private int exercises;
        private string optionalComment;

        //constructor:
        public Discipline(DisciplineName name, DisciplineForGrade grade, int lectures, int exercises)
        {
            this.Name = name;
            this.Grade = grade;
            this.Lectures = lectures;
            this.Exercises = exercises;
        }

        public Discipline(DisciplineName name, DisciplineForGrade grade, int lectures, int exercises, string comment)
        {
            this.Name = name;
            this.Grade = grade;
            this.Lectures = lectures;
            this.Exercises = exercises;
            this.OptionalComment = comment;
        }


        //properties:
        public DisciplineName Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public DisciplineForGrade Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }

        public int Lectures
        {
            get { return this.lectures; }
            set { this.lectures = value; }
        }

        public int Exercises
        {
            get { return this.exercises; }
            set { this.exercises = value; }
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

        

    }
}
