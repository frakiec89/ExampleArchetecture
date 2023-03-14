using ConsoleApp54.Core;
using ConsoleApp54.DB_Mock;
using ConsoleApp54.Content2;

IStudetnService studetnService
    = GetService(TypeContent.Class1); // todo??? зависимость


foreach (Student st in 
    
    studetnService.Students)

{
    Console.WriteLine(st.Name);
}

IStudetnService GetService(TypeContent type = TypeContent.Mock)
{
    switch (type)
    {
        case TypeContent.Mock:
           return new ConsoleApp54.DB_Mock.StudentService();
        case TypeContent.Class1:
            return new ConsoleApp54.Content2.StudentService();
        default:
            break;
    }
    return new ConsoleApp54.Content2.StudentService();
}

public enum TypeContent
{
    Mock , Class1 
}