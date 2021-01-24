using System;

namespace IPractice.Food
{
    public class Meal
    {
        internal Meal() { Console.WriteLine("Meal"); }
    }
    public class Bread
    {
        internal Bread() { Console.WriteLine("Bread"); }
    }
    public class Cheese
    {
        internal Cheese() { Console.WriteLine("Cheese"); }
    }

    public class Lettuce
    {
        internal Lettuce() { Console.WriteLine("Lettuce"); }
    }
    public class Lunch : Meal
    {
        internal Lunch() { Console.WriteLine("Lunch"); }
    }
    public class PortableLunch : Lunch
    {
        internal PortableLunch()
        {
            Console.WriteLine("PortableLunch");
        }
    }

    public class Sandwich : PortableLunch,IFastFood
    {
        Bread b = new Bread();
        Cheese c = new Cheese();
        Lettuce l = new Lettuce();
         
        internal Sandwich()
        {
            FastFood();
            Console.WriteLine("Sandwich");
        }
    

        public void FastFood()
        {
            Console.WriteLine("FastFood");
        }
    }

}
