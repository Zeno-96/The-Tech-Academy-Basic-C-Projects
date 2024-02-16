using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterating_an_Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //This section starts by asking for a color choice and stores it.
            Console.WriteLine("Please tell me your favorite color:");
            string color = Console.ReadLine();

            //This section creates an array of strings and adds their color choice to it.
            string[] sentences = { "You wrote: ", "So your favorite color is: " };
            for (int i = 0; i < sentences.Length; i++)
            {
                sentences[i] = $"{sentences[i]}{color}";
            }

            foreach (string i in sentences)
            {
                Console.WriteLine(i);
            }
            Console.Read();

            //Had to fix the default state of infinity to avoid an endless loop.
            bool infinity = false;
            while (infinity == true)
            {
                Console.WriteLine("HELP!");
            }

            int lessThan = 5;
            for (int x = 1; x <= lessThan; x++)
            {
                Console.WriteLine(x);
            }

            Console.Read();

            string[] fruits = { "apple", "banana", "strawberry" };
            Console.WriteLine("Please enter the name of a fruit to see if its on the list:");
            string choice = Console.ReadLine();

            for (int f = 0; f < fruits.Length; f++)
            {
                if (f == fruits.Length-1 && choice != fruits[f])
                {
                    Console.WriteLine("Sorry, it doesn't look like thats on the list.");
                    break;
                }
                else if (choice == fruits[f])
                {
                    Console.WriteLine("That is on the list!");
                    break;
                }
            }

            Console.Read();

        }
    }
}
