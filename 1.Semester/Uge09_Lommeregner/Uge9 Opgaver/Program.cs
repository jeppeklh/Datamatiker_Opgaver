using System.Transactions;

namespace Uge9_Opgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            while (true)
            {
                Console.Clear();
                TypeLine("Enter a calculation (Press \"Enter\" to quit): ");
                string input = Console.ReadLine();

                if (input == "")
                {
                    break;
                }

                if (char.IsDigit(input[0]) && char.IsDigit(input[2]))
                {


                    int firstDigit = input[0] - '0'; //converting char to int
                    int secondDigit = input[2] - '0';
                    string operatorv = Char.ToString(input[1]);


                    switch (operatorv)
                    {
                        case "+":
                            Console.WriteLine("--------------------------------------------------------------------");
                            Console.WriteLine(c.Add(firstDigit, secondDigit));
                            break;
                        case "-":
                            Console.WriteLine("--------------------------------------------------------------------");
                            Console.WriteLine(c.Subtract(firstDigit, secondDigit));
                            break;
                        case "/":
                            Console.WriteLine("--------------------------------------------------------------------");
                            Console.WriteLine(c.Divide(firstDigit, secondDigit));
                            break;
                        case "*":
                            Console.WriteLine("--------------------------------------------------------------------");
                            Console.WriteLine(c.Multiply(firstDigit, secondDigit));
                            break;
                        default:
                            Console.WriteLine("--------------------------------------------------------------------");
                            TypeLine("Invalid operator!");
                            TypeLine("You Must use the formula (digit operator digit) !!");

                            break;
                    }
                }
                else
                {
                    Console.WriteLine("--------------------------------------------------------------------");
                    TypeLine("You Must use the formula (digit operator digit) !!");
                }
                Console.WriteLine("--------------------------------------------------------------------\n");
                TypeLine("Let's go again");
                System.Threading.Thread.Sleep(500);
                ClearLine(5, "Let's go again.");
                System.Threading.Thread.Sleep(500);
                ClearLine(5, "Let's go again..");
                System.Threading.Thread.Sleep(500);
                ClearLine(5, "Let's go again...");
                System.Threading.Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Red;
                ClearLine(5, "Let's go again...");
                System.Threading.Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Blue;
                ClearLine(5, "Let's go again...");
                System.Threading.Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Green;
                ClearLine(5, "Let's go again...");
                System.Threading.Thread.Sleep(500);
                Console.ResetColor();

            }

        }

        public static void ClearLine(int line, string message)
        {
            Console.CursorTop = line;
            Console.CursorLeft = 0;
            Console.Write(message.PadRight(Console.BufferWidth - 1));
        }

        public static void TypeLine(string line)
        {
            foreach (char c in line)
            {
                RandomColor();
                Console.Write(c);
                System.Threading.Thread.Sleep(30);
            }
            Console.ResetColor();
        }

        public static void RandomColor()
        {
            Random r = new Random();
            int number = r.Next(1, 6);

            switch (number)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
            }
        }
    }
}
