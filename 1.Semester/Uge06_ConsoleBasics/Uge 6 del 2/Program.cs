namespace Uge_6_del_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast navn: ");
            string name = Console.ReadLine();

            Console.Write("Indtast alder: ");
            int age = int.Parse(Console.ReadLine());

            string aldersIndeling = null;

            if (age >= 0 && age <= 12)
            {
                aldersIndeling = "et barn";
            }
            else if (age > 12 && age <= 19)
            {
                aldersIndeling = "en teenager";
            }
            else if (age > 19 && age <= 25)
            {
                aldersIndeling = "en studerende";
            }
            else if (age > 25 && age <= 67)
            {
                aldersIndeling = "i arbejde";
            }
            else if (age > 67)
            {
                aldersIndeling = "en pensionist";
            }

            Console.WriteLine(name + " er " + age + " år gammel of er " + aldersIndeling);

            Console.ReadLine();
        }
    }
}
