using IPractice.InterfaceInheritance;
using System;

namespace IPractice.Fullnheritance
{
    class ClassB : ClassA, D
    {

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



        static void Main()
        {
            ClassB b = new ClassB();
            M1(b);
            M2(b);
            M3(b);
            M4(b);

        }

        static void M1(A a)
        {
            a.Print();
            a.Print("hey");
        }

        static void M2(B b)
        {
            b.Save();
            b.Save("B");
        }
        static void M3(C c)
        {
            c.Request();
            c.Request("C");
        }
        static void M4(D d)
        {
            d.Write();

        }

    }
}
