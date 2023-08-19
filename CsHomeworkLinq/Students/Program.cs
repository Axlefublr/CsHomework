using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Students;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        var classes = new[]
        {
            new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
            new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
            new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
        };
        var allStudents = GetAllStudents(classes);

        Console.WriteLine(string.Join(" ", allStudents));
    }

    static string[] GetAllStudents(Classroom[] classes)
    {
        var allStudents = classes.SelectMany(classroom => classroom.Students);
        return allStudents.ToArray();
    }

}

public class Classroom
{
    public List<string> Students = new List<string>();
}