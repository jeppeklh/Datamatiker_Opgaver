using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge9_Opgaver
{
    internal class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public double Divide(int x, int y)
        {
            double result = (double) x / y;
            return result;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
