
using Spectre.Console;

namespace Disaheim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amulet amu = new Amulet("");
                        Console.WriteLine(amu.ToString());

            Book book = new Book("");
            Console.WriteLine(book.ToString());

            Course course = new Course("");
            Console.WriteLine(course.ToString());
            
            
        }
    }
}
