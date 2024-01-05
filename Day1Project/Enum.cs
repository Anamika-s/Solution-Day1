using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project
{
    enum Choice { add=1, subtract, product, divide};
    internal class Enum
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
                if (ch == (byte)Choice.add)
                    Console.WriteLine($"Sum is {x + y}");
                else if (ch == (byte)Choice.subtract)
                    Console.WriteLine($"Difference is {x - y}");
                else if (ch == (byte)Choice.product)
                    Console.WriteLine($"Product is {x * y}");
                else if (ch == (byte)Choice.divide)
                    Console.WriteLine($"Quotient is {x / y}");
                else
                    Console.WriteLine("Inv choice");
            }
        }
    }


