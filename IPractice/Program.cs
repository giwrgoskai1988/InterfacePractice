using IPractice.Food;
using IPractice.Fullnheritance;
using IPractice.InterfaceInheritance;
using IPractice.Music;
using System;

namespace IPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            IDummy d = new Dumb();
            d.Print();
            d.Print(4);
            d.Print("Hello");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            D b = new ClassB();

            M1(b);
            M2(b);
            M3(b);
            M4(b);
            ClassAbstract c = new ClassB();
            c.PrintMe();
            //GC.Collect();
            //GC.WaitForPendingFinalizers();


            IFastFood f = new Sandwich();

            f.FastFood();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Sandwich a = new Sandwich();
            a.FastFood();

            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            IPlayableInstrument[] orchestra = new IPlayableInstrument[5];
            int i = 0;
            orchestra[i++] = new Wind();
            orchestra[i++] = new Percussion();
            orchestra[i++] = new Stringed();
            orchestra[i++] = new Brass();
            orchestra[i++] = new Woodwind();
            TuneAll(orchestra);

        }



        static void Tune(IPlayableInstrument i)
        {
            i.Play();
        }
        static void TuneAll(IPlayableInstrument[] e)
        {
            for (int i = 0; i < e.Length; i++)
                Tune(e[i]);
        }



        public static void M1(A a)
        {
            a.Print();
            a.Print("hey");
        }

        public static void M2(B b)
        {
            b.Save();
            b.Save("B");
        }
        public static void M3(C c)
        {
            c.Request();
            c.Request("C");
        }
        public static void M4(D d)
        {
            d.Write();

        }
    }
}
