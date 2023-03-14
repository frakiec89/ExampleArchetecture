using ConsoleApp54.Core;
using System;
using System.Collections.Generic;
namespace ConsoleApp54
{
    internal class MyConsole 
    {
        public IStudetnService Service { get; }
        public MyConsole(IStudetnService service) // проброс  зависимости
        {
            Service = service;
        }

        public void  Start () 
        {
            foreach (Student st in Service.Students)

            {
                Console.WriteLine(st.Name);
            }

        }
    }

    public class   Bild
    {

       public static IStudetnService GetService(TypeContent type = TypeContent.Mock)
        {
            switch (type)
            {
                case TypeContent.Mock:
                    return new ConsoleApp54.DB_Mock.StudentService();
                case TypeContent.Class1:
                    return new ConsoleApp54.Content2.StudentService();
            }
            return new ConsoleApp54.Content2.StudentService();
        }
    }

    public enum TypeContent
    {
        Mock, Class1
    }
}
