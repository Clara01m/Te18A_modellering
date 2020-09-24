using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Modellering
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer= "nothing"; 
            XmlSerializer charmanderSerializer = new XmlSerializer(typeof(Charmander));

            Charmander buddy = new Charmander();
            Console.WriteLine("you found a charmander");
            Console.WriteLine("What would you like to name it?");
            buddy.name= Console.ReadLine();
            Console.WriteLine("Great choise!");
            Console.WriteLine("It has " , buddy.hp , " Hp"); 
            Console.ReadLine();
            FileStream file = File.Open(@"Charmander.xml", FileMode.OpenOrCreate);
            charmanderSerializer.Serialize(file, buddy);
            file.Close();

            Bulbasaur enemy = new Bulbasaur(); 
            Console.WriteLine ("You run into a hostile bulbasaur, will you fight it?");
            answer = Console.ReadLine(); 
            if (answer == "Yes")
            { 
                while (buddy.hp > 0 && enemy.hp2 > 0)  
                {
                Console.WriteLine("Let the tournament begin");
                enemy.hp2= enemy.hp2 - buddy.attack;
                Console.WriteLine("You got the enemy down to ", enemy.hp2);
                buddy.hp= buddy.hp - enemy.attack2;
                Console.WriteLine("It got you down to ", buddy.hp);
                }
                Console.WriteLine();
            }
            else 
            {
                Console.WriteLine(".... Coward"); 
            
            }
            Console.ReadLine(); 

        }
    }
}
