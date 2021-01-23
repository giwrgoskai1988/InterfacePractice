using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPractice
{
    class Dumb : IDummy
    {
        public void Print()
        {
            Console.WriteLine("Simple Print");
        }

        public void Print(int a)
        {
            Console.WriteLine($"Printint integer : {a}");
           
        }

        public void Print(string b)
        {
            Console.WriteLine($"Printing string : {b}");
        }
    }
}
