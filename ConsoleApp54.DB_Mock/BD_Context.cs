using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54.DB_Mock
{
    internal class BD_Context_Mock
    {
        internal List<Student> Students = new List<Student>()
        { new Student () {  Name="Ivan" , FirstName="Ivanov" , Id=1} };
    }
}
