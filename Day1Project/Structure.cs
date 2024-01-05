using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project
{
    struct Record
    {
          int rn;
        string name;
        string address;
        public Record(int rn, string name , string address)
        {
            this.rn = rn;
            this.name = name;
            this.address = address;

        }
        public void Get()

        {
            Console.WriteLine("Enter Rn");
            rn = 1;
            Console.WriteLine("ENter name");
            name = "aa";
            Console.WriteLine("Enter address");
            address = "aaaa";
        }
        public void Display()
        {
            Console.WriteLine($"Name is {name}");

        }
    }

    //struct D : Record
    //{

    //}
    internal class Structure
    {
        static void Main()
        {
            Record r = new Record();
            r.Get();
            r.Display();
            


        }
    }
}
