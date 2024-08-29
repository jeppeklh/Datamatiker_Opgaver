using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge_14_Algoritmer
{
    internal class SearchAlgorithms
    {
        public string LinearSearch(Student[] students, string fullName)
        {
           for (int i = 0; i < students.Length; i++)
            {
                if (students[i].FullName == fullName)
                {
                    return students[i].FullName;
                }
            }
            return null;
        }
    }
}
