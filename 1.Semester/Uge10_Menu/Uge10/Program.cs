namespace Uge10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opgave 1.1
            //int alder1 = 25;
            //int alder2 = 30;
            //int alder3 = 25;
            //int alder4 = 30;
            //int alder5 = 25;
            //int alder6 = 30;

            //double gennemsnitsalder = (double) (alder1 + alder2 + alder3 + alder4 + alder5 + alder6) / 6;

            //Console.WriteLine(alder1);
            //Console.WriteLine(alder2);
            //Console.WriteLine(alder3);
            //Console.WriteLine(alder4);
            //Console.WriteLine(alder5);
            //Console.WriteLine(alder6);
            //Console.WriteLine("\n" + gennemsnitsalder);

            //Opgave 1.2
            //int[] alderArray = { 25, 30, 25, 30, 25, 30 };

            //int sum = 0;

            //for (int i = 0; i < alderArray.Length; i++)
            //{
            //    Console.WriteLine(alderArray[i]);
            //    sum += alderArray[i];
            //}
            //double gennemsnitsalder = (double)sum / alderArray.Length;
            //Console.WriteLine("\n" + gennemsnitsalder);

            //Opgave 1.3
            //int[] alderArray = { 25, 30, 27, 30, 25, 30 };

            //Console.Write("Hvilken alder leder du efter? ");
            //int input = int.Parse(Console.ReadLine());
            //bool found = false;

            //for (int i = 0; i < alderArray.Length; i++)
            //{
            //    if (alderArray[i] == input)
            //    {
            //        found = true;
            //        break; //ingen grund til at køre hele arrayet i gennem når vi har fundet alderen
            //    }                
            //}
            //if(found)
            //{
            //    System.Console.WriteLine("Alderen " + input + " blev fundet!");
            //}
            //else
            //{
            //    System.Console.WriteLine("Alderen " + input + " blev ikke fundet :-(");
            //}

            //Opgave 1.4
            //try
            //{
            //    Console.Write("Hvor mange personer? ");
            //    int amountOfPersons = int.Parse(Console.ReadLine());

            //    int[] alderArray = new int[amountOfPersons];

            //    for (int i = 0; i < amountOfPersons; i++)
            //    {
            //        Console.Write(i + 1 + ". persons alder: ");
            //        int input = int.Parse(Console.ReadLine());
            //        alderArray[i] = input;
            //    }

            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine("Indtast venligst et nummer!");
            //}

            //Opgave 1.5
            //Console.Write("Hvor mange personer? ");
            //string input = Console.ReadLine();
            //if (int.TryParse(input, out int amountOfPersons)) {
            //    //Alt gik efter planen
            //}
            //else
            //{
            //    Console.WriteLine("\"" + input + "\" er ikke et tal! \nIndtast venligst et tal");
            //}

            //int[] alderArray = new int[amountOfPersons];

            //for (int i = 0; i < amountOfPersons; i++)
            //{
            //    Console.Write(i + 1 + ". persons alder: ");
            //    string alder = Console.ReadLine();
            //   if(int.TryParse(alder, out alderArray[i]))
            //    {
            //        //Hvis alder er et tal
            //    }
            //   else
            //    {
            //        Console.WriteLine("\"" + alder + "\" er ikke et tal! \nIndtast venligst et tal");
            //    }
            //}
        }
    }
}
