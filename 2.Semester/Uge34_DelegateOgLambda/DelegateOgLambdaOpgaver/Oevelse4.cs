using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DelegateOgLambdaOpgaver;

internal class Oevelse4
{
    Func<int, int, int> sum = (x, y) =>
    {
        int result = x + y;
        return result;
    };


    Action<int> delegate2 = x =>
    {
        int result = 0;
        for (int i = 0; i < 10; i++)
        {
            result += x;
        }
    };


    Func<int, int> delegate3 = x => x * x;  



    
}
