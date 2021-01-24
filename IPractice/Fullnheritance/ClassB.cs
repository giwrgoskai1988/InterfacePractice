using IPractice.InterfaceInheritance;
using System;

namespace IPractice.Fullnheritance
{
    class ClassB : ClassA, D
    {

        public override void PrintMe()
        {
            base.PrintMe();
            Console.WriteLine("Abstract from B");
        }

        public void Print()
        {
            Console.WriteLine("A!!");
        }

        public void Print(string a)
        {
            Console.WriteLine($"{a} from A!!");
        }

        public void Request()
        {
            Console.WriteLine("Request from C!!");
        }

        public void Request(string a)
        {
            Console.WriteLine($"Request {a} from C!!");
        }

        public void Save()
        {
            Console.WriteLine("Save from B!!");
        }

        public void Save(string b)
        {
            Console.WriteLine($"Save {b} from B!!");
        }

        public void Write()
        {
            Console.WriteLine("Write from D!!");
        }


        ~ClassB()
        {
            Console.WriteLine("Done");
        }

    }
}
