using ConsoleApp54.Core;
using System.Collections.Generic;

namespace ConsoleApp54.DB_Mock
{
    public class StudentService : IStudetnService
    {
        public List<Core.Student> Students 
        { get 
            {
                return GetStudent(); 
            }
            set 
            {
                throw new NotImplementedException();
            } 
        }

        private List<Core.Student> GetStudent()
        {
            BD_Context_Mock bD = new BD_Context_Mock();
            List<Student> students = bD.Students; // из  бд 

            List<Core.Student> studentsCore = new List<Core.Student>(); // вернем

            foreach (Student st in students)
            {
                studentsCore.Add(GetStudentCore(st));
            }
            return studentsCore;
        }
        private Core.Student GetStudentCore(Student st) // мапинг 
        {
            Core.Student newStudent = new Core.Student();
            newStudent.Id = st.Id;
            newStudent.Name = st.FirstName + " " + st.Name  ; //логика преобразования
            return newStudent;
        }
    }
}
