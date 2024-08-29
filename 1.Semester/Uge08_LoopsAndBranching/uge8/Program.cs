using System.ComponentModel;

namespace uge8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //opgave 1.4
            //string str = "Visio stinker!";
            //Console.WriteLine(str[1]);
            //Console.WriteLine(str[3]);
            //Console.WriteLine(str[5]);

            //opgave 1.5
            //Console.Write("Skriv noget: ");
            //string str = Console.ReadLine();
            //int index = 0;

            //while (index < str.Length)
            //{
            //    Console.WriteLine(str[index]);
            //    index++;
            //}

            //opgave 1.6
            //Console.Write("Skriv noget: ");
            //string input = Console.ReadLine();
            //int index = 0;

            //do
            //{
            //    Console.WriteLine("{0}: " + input[index], index);
            //    index++;
            //} while (index < input.Length);

            //opgave 1.7
            //Console.Write("First number: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Second number: ");
            //int b = int.Parse(Console.ReadLine());
            //int heltalsKvoitienten = a / b;
            //int rest = a % b;

            //Console.WriteLine("division:{0} remainder: {1}", heltalsKvoitienten, rest);

            //opgave 1.8
            //while (true)
            //{
            //    Console.Write("Enter your name (Type exit to quit): ");
            //    string name = Console.ReadLine();
            //    if (name == "exit")
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Hello " + name + "!");
            //}

            //opgave 1.9
            //Console.WriteLine("Skriv noget: ");
            //string str = Console.ReadLine();
            //int index = 0;

            //while (index < str.Length)
            //{
            //    if(index % 2 == 0)
            //    {
            //        Console.WriteLine(str[index]);
            //    }
            //    index++;
            //}

            //opgave 1.10
            Console.Write("Enter calculation: ");
            string str = Console.ReadLine();
            int index = 0;
            int calculation = 0;
            string currentOperator = "+";

            while (index < str.Length)
            {
                switch (str[index])
                {
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                        currentOperator = str[index].ToString();
                        break;
                }
                switch (str[index])
                {     
                    case '1':
                        calculation = PerformOperation(calculation, currentOperator, 1);
                        break;
                    case '2':
                        calculation = PerformOperation(calculation, currentOperator, 2);
                        break;
                    case '3':
                        calculation = PerformOperation(calculation, currentOperator, 3);
                        break;
                    case '4':
                        calculation = PerformOperation(calculation, currentOperator, 4);
                        break;
                    case '5':
                        calculation = PerformOperation(calculation, currentOperator, 5);
                        break;
                    case '6':
                        calculation = PerformOperation(calculation, currentOperator, 6);
                        break;
                    case '7':
                        calculation = PerformOperation(calculation, currentOperator, 7);
                        break;
                    case '8':
                        calculation = PerformOperation(calculation, currentOperator, 8);
                        break;
                    case '9':
                        calculation = PerformOperation(calculation, currentOperator, 9);
                        break;

                }
                index++;
              
            }
            Console.WriteLine(calculation);
        }

        static int PerformOperation(int firstValue, string currentOperator, int secondValue)
        {
            switch(currentOperator)
            {
                case "-":
                    return firstValue - secondValue;
                case "*":
                    return firstValue * secondValue;
                case "/":
                    return firstValue / secondValue;
                default:
                    return firstValue + secondValue;
            }
        }
    }
}
