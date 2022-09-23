using System.ComponentModel;

namespace Abstraction
{
    //  Abstract class
    abstract class Hero
    {
        // Abstract method
        public abstract void attack();

        // Regular method
        public void defend()
        {
            Console.WriteLine("Hero defends.");
        }
    }

    // Derived class (inherits from Hero)
    class Druid : Hero
    {
        // Override method
        public override void attack()
        {
            // Body of attack
            Console.WriteLine("Druid shifts into animal and attacks.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Druid myDruid = new Druid();
            myDruid.attack();
            myDruid.defend();
        }
    }
}