using System.Runtime.CompilerServices;

namespace Uge_14_Algoritmer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataHandler dataHandler = new DataHandler("students.txt");
            SortingAlgorithms sa = new SortingAlgorithms();
            SearchAlgorithms searchA = new SearchAlgorithms();
            Student[] students = dataHandler.LoadStudents();


            //sa.SelectionSort(students);

            //foreach (Student student in students)
            //{

            //    Console.WriteLine(student.MakeTitle());

            //}

            //sa.BubbleSort(students, students.Length);
            
            //foreach (Student student in students )
            //{

            //    Console.WriteLine(student.MakeTitle());

            //}
            //int n = students.Length;
            //sa.quickSort(students, 0 ,n-1);
            //foreach (Student student in students)
            //{

            //    Console.WriteLine(student.MakeTitle());

            //}

            
            Console.WriteLine(searchA.LinearSearch(students, "Jesper Helstrup"));

        }
    }
}
