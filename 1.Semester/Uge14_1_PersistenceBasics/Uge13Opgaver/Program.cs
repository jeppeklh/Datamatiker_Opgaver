using System.Globalization;

namespace Uge13Opgaver
{
    public class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string relativePath = "Data.txt";
            string fullPath = Path.Combine(currentDirectory, relativePath);

            Person person = new Person("Anders Andersen", new DateTime(1975, 8, 24), 175.9, true, 3);
            DataHandler handler = new DataHandler(fullPath);
            handler.SavePerson(person);

            Console.Write("Writing Person: ");
            Console.WriteLine(person.MakeTitle());

            Console.ReadLine();
        }
    }
}
