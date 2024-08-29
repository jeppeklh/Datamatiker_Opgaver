namespace _2._1_Length__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string navn = "Jeppe";
            Console.WriteLine(navn.Length);
            Console.WriteLine(navn.Substring(3));

            char yoyo = 'J';
            int index = navn.IndexOf(yoyo);
            if(index == -1) { Console.WriteLine("Character not found"); }
            else { Console.WriteLine(index); }

            PrintIndexOfCharacterInName("Jeppe", 'e');
            
            
        }

        static void PrintIndexOfCharacterInName(string name, char character)
        {
        int index = name.IndexOf(character);
        
        if(index == -1){ Console.WriteLine("Character not found");}
        else { Console.WriteLine(index); }
        }
    }
}

