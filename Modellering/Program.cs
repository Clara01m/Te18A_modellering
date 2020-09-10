using System;

namespace Modellering
{
    class Program
    {
        static void Main(string[] args)
        {
            Charmander buddy = new Charmander();
            Console.WriteLine("you found a charmander");
            Console.WriteLine("What would you like to name it?");
            buddy.name= Console.ReadLine();
            Console.WriteLine("Great choise!" );
            Console.WriteLine("It has " , buddy.hp , " Hp"); 
            Console.ReadLine();
        }
    }
}
