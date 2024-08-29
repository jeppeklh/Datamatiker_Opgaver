using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge_14_Algoritmer
{
    internal class SortingAlgorithms
    {
        public void SelectionSort(Student[] students)
        {
            int n = students.Length;

            // One by one move boundary of unsorted subarray 
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array 
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (students[j].GroupNumber < students[min_idx].GroupNumber)
                        min_idx = j;

                // Swap the found minimum element with the first 
                // element 

                Student temp = students[min_idx];
                students[min_idx] = students[i];
                students[i] = temp;
            }
        }

        public void BubbleSort(Student[] students, int n)
        {
            int i, j;
            Student temp;
            //bool swapped;
            for (j = 0; j < n - 1; j++)
            {
                //swapped = false;
                for (i = j + 1; i < n; i++)
                {
                    if (students[j].FullName.CompareTo(students[i].FullName) > 0)
                    {

                        // Swap arr[j] and arr[j+1]
                        temp = students[j];
                        students[j] = students[i];
                        students[i] = temp;
                        //swapped = true;
                    }
                }

                //// If no two elements were
                //// swapped by inner loop, then break
                //if (swapped == false)
                //    break;

            }


        }
        static void swap(Student[] students, int i, int j)
        {
            Student temp = students[i];
            students[i] = students[j];
            students[j] = temp;
        }
        static int partition(Student[] students, int low, int high)
        {
            // Choosing the pivot
            Student pivot = students[high];

            // Index of smaller element and indicates
            // the right position of pivot found so far
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {

                // If current element is smaller than the pivot
                if (students[j].FullName.CompareTo(pivot.FullName) < 0)
                {

                    // Increment index of smaller element
                    i++;
                    swap(students, i, j);
                }
            }
            swap(students, i + 1, high);
            return (i + 1);
        }

        public void quickSort(Student[] students, int low, int high)
        {
            if (low < high)
            {
                int pi = partition(students, low, high);

                quickSort(students, low, pi - 1);
                quickSort(students, pi + 1, high);
            }

        }
    }
}
