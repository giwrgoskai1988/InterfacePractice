using System;

namespace IPractice.Fullnheritance
{
    public class ClassA : ClassAbstract
    {
        protected const string a = "Hello from Base";

        public override void PrintMe()
        {
            Console.WriteLine("Abstract Method in Class A");
        }
    }
}
