namespace Uge_6_menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Min fantastiske menu \n");
            Console.WriteLine("1. Gør dit");
            Console.WriteLine("2. Gør dat");
            Console.WriteLine("3. Gør noget");
            Console.WriteLine("4. Få svaret på livet, universet og alting");
            Console.WriteLine();
            Console.WriteLine("(Tryk menupunkt 1, 2, 3 eller 4)");

            int input = int.Parse(Console.ReadLine());
            string message = "";

            switch (input)
            {
                case 1:
                    message = "Gør dit";
                    break;
                case 2:
                    message = "Gør dat";
                    break;
                case 3:
                    message = "Gør noget";
                    break;
                case 4:
                    message = "42";
                    break;
                default:
                    message = "Forkert valg";
                    break;
            }


            //if (input == 1) { message = "Gør dit"; }
            //else if (input == 2) { message = "Gør dat"; }
            //else if (input == 3) { message = "Gør noget"; }
            //else if (input == 4) { message = "42"; }
            //else { message = "Forkert valg"; }

            Console.WriteLine("Punkt {0} er valgt: {1}", input, message);

            Console.ReadLine();
        }
    }
}