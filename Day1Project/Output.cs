using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project
{
    internal class Output
    {
        static void Main()
        {
            int add, subtract, product, rem;
            Opeartions(90,10 , out add , out subtract, out product, out rem);
            Console.WriteLine("Sum is " + add);
        }
        static int Opeartions(int x, int y, out int add ,
            out int subtract,
            out int product,
            out int rem)
        {
            product = x * y;
            rem = x % y;
            add= x + y;
            subtract= x-y;
            return 0;
        }
    }
}
