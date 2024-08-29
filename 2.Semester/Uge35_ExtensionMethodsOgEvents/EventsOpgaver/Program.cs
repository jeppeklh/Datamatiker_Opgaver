namespace Opgave4;

internal class Program
{
    static void Main(string[] args)
    {

        Sparegris sparegris = new Sparegris();
        Subscriber subscriber = new Subscriber();

        subscriber.Subscribe(sparegris);


        while (true)
        {
            Console.Clear();
            Console.WriteLine("Hvor mange penge vil du ligge i sparegrisen?\nBalance: " + sparegris.GetBalance());

            double input = double.Parse(Console.ReadLine());
            if (input == 0) break;
            sparegris.InsertAmount(input);
        }
    }
}
