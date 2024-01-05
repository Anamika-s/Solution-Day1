using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project
{
    internal class Switch
    {
        static void Main()
        {
            int x, y, ch;
            Console.WriteLine("Enter No1 ");
            x = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter No2 ");

            y = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter choice");
            ch = Byte.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                case 5:
                    Console.WriteLine($"Sum is {x + y}"); break;
                case 2:
                    Console.WriteLine($"Difference is {x - y}"); break;
                case 3:
                    Console.WriteLine($"Product is {x * y}"); break;
                case 4:
                    Console.WriteLine($"Quotient is {x / y}"); break;
                default:
                    Console.WriteLine("Inv choice"); break;
            }
        }
    }
}