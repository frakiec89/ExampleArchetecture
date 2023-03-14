using ConsoleApp54.Core;

namespace ConsoleApp54.Content2
{
    internal  class Class1
    {
       internal static string Name = "Ivan";
    }

    public class StudentService : IStudetnService
    {
        public List<Student> Students 
        { get
            {
                return new List<Student>() 
                { new Student { Name = Class1.Name } };
            }
            set
            { 
            } 
        }
    }
}