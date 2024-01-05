using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project
{
    internal class Sequential
    {
        static void Main()
        {
            int x, y;
            Console.WriteLine("Enter No1 ");
            x = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter No2 ");
            y = Byte.Parse(Console.ReadLine());
            Console.WriteLine($"Sum is {x + y}");
            Console.WriteLine($"Difference is {x - y}");
            Console.WriteLine($"Product is {x * y}");
            Console.WriteLine($"Quotient is {x / y}");


        }
    }
}
