namespace Disaheim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amulet amu = new Amulet("nej");
            amu.Quality = Level.medium;
            Console.WriteLine(amu.ToString());

            Book book = new Book("Slut", "test");
            Console.WriteLine(book.ToString);
        }
    }
}
