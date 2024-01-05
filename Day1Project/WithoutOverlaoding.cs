using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project
{
    internal class WithoutOverlaoding
    {
        static void Main()
        {

            Sum(10, 2);

        }

          static void Sum(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        static void Sum1(int x, int y, int z)
        {
            Console.WriteLine(x + y);
        }

        static void Sum2(float x, int y)
        {
            Console.WriteLine(x + y);
        }
    }
}
