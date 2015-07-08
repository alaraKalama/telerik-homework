using System;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;

using System.Collections.Generic;

namespace SoftwareAcademy
{
    public interface ITeacher
    {
        string Name { get; set; }
        void AddCourse(ICourse course);
        string ToString();
    }

    public class Teacher : ITeacher
    {
        private string name;
       // private ICollection<ICourse> courses;

        public Teacher(string name)
        {
            this.Name = name;
            this.Courses = new List<ICourse>();
        }

        public string Name
        {
            get { return this.name; }

            set
            {
                Validator.ValidateName(value);
                this.name = value;
            }
        }

        public ICollection<ICourse> Courses {get; set;}
        

        public void AddCourse(ICourse course)
        {
            Validator.ValidateNotNull(course);
            this.Courses.Add(course);
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(String.Format("Teacher: Name={0}", this.Name));
            if (this.Courses.Count > 0)
            {
                result.Append(String.Format("; Courses=[{0}]", (string.Join(", ", this.Courses.Select(course => course.Name)))));
            }
            return result.ToString();
        }
    }

    public interface ICourse
    {
        string Name { get; set; }
        ITeacher Teacher { get; set; }
        void AddTopic(string topic);
        string ToString();
    }

    public abstract class Course : ICourse
    {
        private string name;
        private ICollection<string> program;

        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.Program = new List<string>();
        }

        public Course(string name)
        {
            this.Name = name;
            this.Program = new List<string>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                Validator.ValidateName(value);
                this.name = value;
            }
        }

        public ITeacher Teacher
        {
            get;
            set;
        }

        public ICollection<string> Program
        {
            get { return this.program; }
            set { this.program = value; }
        }

        public CourseType CourseType { get; protected set; }

        public void AddTopic(string topic)
        {
            Validator.ValidateName(topic);
            this.Program.Add(topic);
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(String.Format("Name={0}; ", this.Name));
            if (this.Teacher != null  )
                result.Append(String.Format("Teacher={0}; ", this.Teacher.Name));
            
            if(this.Program.Count > 0)
                result.Append(String.Format("Topics=[{0}];", String.Join(", ", this.Program.ToArray())));
            
            return result.ToString();
        }
    }

    public enum CourseType
    {
        LocalCourse,
        OffsiteCourse
    }

    public interface ILocalCourse : ICourse
    {
        string Lab { get; set; }
    }

    public class LocalCourse : Course, ILocalCourse
    {
        private string lab;

        public LocalCourse(string name, ITeacher teacher, string lab)
            : base(name, teacher)
        {
            this.Lab = lab;
            this.CourseType = CourseType.LocalCourse;
        }

        public LocalCourse(string name, string lab)
            : base(name)
        {
            this.Lab = lab;
            this.CourseType = CourseType.LocalCourse;
        }

        public string Lab
        {
            get { return this.lab; }
            set
            {
                Validator.ValidateName(value);
                this.lab = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(String.Format("{0}: ", this.CourseType));
            result.Append(base.ToString());
            result.Append(String.Format(" Lab={0}", this.Lab));
            return result.ToString();
        }

    }

    public interface IOffsiteCourse : ICourse
    {
        string Town { get; set; }
    }

    public class OffsiteCourse : Course, IOffsiteCourse
    {
        private string town;

        public OffsiteCourse(string name, ITeacher teacher, string town)
            : base(name, teacher)
        {
            this.Town = town;
            this.CourseType = CourseType.OffsiteCourse;

        }

        public OffsiteCourse(string name, string town)
            : base(name)
        {
            this.Town = town;
            this.CourseType = CourseType.OffsiteCourse;

        }

        public string Town
        {
            get { return this.town; }

            set
            {
                Validator.ValidateName(value);
                this.town = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(String.Format("{0}: ", this.CourseType));
            result.Append(base.ToString());
            result.Append(String.Format(" Town={0}", this.Town));
            return result.ToString();
        }
    }

    public interface ICourseFactory
    {
        ITeacher CreateTeacher(string name);
        ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab);
        IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town);
    }

    public class CourseFactory : ICourseFactory
    {
        public ITeacher CreateTeacher(string name)
        {
            return new Teacher(name);
        }

        public ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab)
        {
            return new LocalCourse(name, teacher, lab);
        }

        public IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town)
        {
            return new OffsiteCourse(name, teacher, town);
        }
    }

    public class Validator
    {
        public static void ValidateName(string name, string message = null)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(message);
            }
        }

        public static void ValidateNotNull(object obj, string message = null)
        {
            if (obj == null)
            {
                throw new NullReferenceException(message);
            }
        }
    }

    public class SoftwareAcademyCommandExecutor
    {
        static void Main()
        {
            string csharpCode = ReadInputCSharpCode();
            CompileAndRun(csharpCode);
        }

        private static string ReadInputCSharpCode()
        {
            StringBuilder result = new StringBuilder();
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                result.AppendLine(line);
            }
            return result.ToString();
        }

        static void CompileAndRun(string csharpCode)
        {
            // Prepare a C# program for compilation
            string[] csharpClass =
            {
                @"using System;
                  using SoftwareAcademy;

                  public class RuntimeCompiledClass
                  {
                     public static void Main()
                     {"
                        + csharpCode + @"
                     }
                  }"
            };

            // Compile the C# program
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateInMemory = true;
            compilerParams.TempFiles = new TempFileCollection(".");
            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);
            CSharpCodeProvider csharpProvider = new CSharpCodeProvider();
            CompilerResults compile = csharpProvider.CompileAssemblyFromSource(
                compilerParams, csharpClass);

            // Check for compilation errors
            if (compile.Errors.HasErrors)
            {
                string errorMsg = "Compilation error: ";
                foreach (CompilerError ce in compile.Errors)
                {
                    errorMsg += "\r\n" + ce.ToString();
                }
                throw new Exception(errorMsg);
            }

            // Invoke the Main() method of the compiled class
            Assembly assembly = compile.CompiledAssembly;
            Module module = assembly.GetModules()[0];
            Type type = module.GetType("RuntimeCompiledClass");
            MethodInfo methInfo = type.GetMethod("Main");
            methInfo.Invoke(null, null);
        }
    }
}
