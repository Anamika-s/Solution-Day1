using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project
{
    internal class Conditionl
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
            if(ch==1)
            Console.WriteLine($"Sum is {x + y}");
            else if(ch==2)
                Console.WriteLine($"Difference is {x - y}");
            else if(ch==3)
                Console.WriteLine($"Product is {x * y}");
            else if(ch==4)
                Console.WriteLine($"Quotient is {x / y}");
            else
                Console.WriteLine("Inv choice");
        }
    }
}
