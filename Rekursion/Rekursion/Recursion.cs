using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekursion
{
    public class Recursion
    {
        public int Fakultät_Recursion(int number)
        {
            if (number == 0)
                return 1;

            return number * Fakultät_Recursion(number - 1);
        }

        public int Fibonacci_Recursion(int number)
        {
            if (number < 2)
                return number;
            return Fibonacci_Recursion(number - 1) + Fibonacci_Recursion(number - 2);
        }
    }
}
