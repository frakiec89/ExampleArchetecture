using ConsoleApp54.Core;
using ConsoleApp54.DB_Mock;

IStudetnService studetnService
    = new StudentService(); // todo??? зависимость


foreach (Student st in 
    
    studetnService.Students)
{
    Console.WriteLine(st.Name);
}