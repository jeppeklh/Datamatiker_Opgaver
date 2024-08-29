namespace _1._2_Hældning_af_linjestykke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintHældning(3, 3, 5, 3);
            PrintHældning(3, 3, 5, 5);
            PrintHældning(3, 3, 5, 4);
            Console.Read();
        }

        static void PrintHældning(int x1, int y1, int x2, int y2)
        {
            double h = 1.0 * (y2 - y1) / (x2 - x1);

            Console.WriteLine("x1: " + x1);
            Console.WriteLine("y1: " + y1);
            Console.WriteLine("x2: " + x2);
            Console.WriteLine("y2: " + y2);
            Console.WriteLine("Hældning: " + h);
        } 

    }
}
