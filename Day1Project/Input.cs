using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project
{
    internal class Input
    {
        static void Main()
        {
            //string name;
            //Console.WriteLine("Enter Name");
            //name = Console.ReadLine();
            //Console.WriteLine("NAme is " + name);   // using + operator
            //Console.WriteLine("Name is {0}", name); // using placeholder
            //Console.WriteLine($"NAme is {name}"); // using string interpoltaion

            byte rn;
            //try
            //{
            //    Console.WriteLine("Enter RollNo");
            //    //rn = Convert.ToByte(Console.ReadLine());
            //    rn = Byte.Parse(Console.ReadLine());
            //    Console.WriteLine($"No is {rn}");
            //} catch(Exception ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}


            Console.WriteLine("Enter RollNo");
            //rn = Convert.ToByte(Console.ReadLine());
            //rn = Byte.Parse(Console.ReadLine());
            Byte.TryParse(Console.ReadLine(), out rn);
            
            Console.WriteLine($"No is {rn}");
        }
    }
}
