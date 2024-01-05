
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project
{
    internal class Named
    {
        static void Main()
        {

            Display(pincode: 100, address: "New Delhi", id: 100, name: "Ajay");
         Console.WriteLine(Sum(1,2,3));
            Console.WriteLine(Sum(1,2,3,4,4,4,4,4,4,4,4,4));
                }
        static void Display(int id, string name, string address, int pincode)
        
            {
            Console.WriteLine(id +  " "+ name);
        }

        //static int Sum(int x, int y, int z)
        //{
        //    return x + y + z;
        //}
        static int Sum(params int[] values)
        {
            int sum = 0;
            foreach(int value in values)
            {
                sum += value;
            }
            return sum;
        }
    }
}
