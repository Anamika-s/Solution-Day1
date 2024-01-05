using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project
{
    internal class WithOverloading
    {
        static void Main()
        {

            Sum(10, 2);
            Sum(11.6f, 9);
            SI(12000, 2, 8);
            SI(12000, 3);
        }

        static void Sum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        //static int Sum(int x, int y)
        //{
        //    Console.WriteLine(x + y);
        //}
        static void Sum(int x, int y, int z)
        {
            Console.WriteLine(x + y);
        }

        static void SI(int p, int r=5 , int t=10)
        {
            Console.WriteLine(p*r*t/100);
        }


        static void Sum(float x, int y)
        {
            Console.WriteLine(x + y);
        }
    }
}
