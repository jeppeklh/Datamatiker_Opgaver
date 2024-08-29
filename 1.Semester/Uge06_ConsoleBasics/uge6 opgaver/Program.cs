namespace uge6_opgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast navn: ");
            string name = Console.ReadLine();
            Console.WriteLine("Navn: " + name);

            Console.Write("Indtast alder: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Alder: " + age);
            age -= 10;

            Console.WriteLine(name + " er " + age + " år gammel");

            Console.ReadLine();
        }
    }
}
