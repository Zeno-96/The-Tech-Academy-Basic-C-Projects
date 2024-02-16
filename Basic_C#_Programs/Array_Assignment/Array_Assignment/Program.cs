using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Assignment
{
    class Program
    {
        static void Main()
        {
            //We'll start by defining some arrays to work with.
            string[] sentences = { "This is the wrong one", "This is the correct one!", "This is also the wrong one..." };
            int[] numbers = {0, 1, 2};

            //First we'll have the user pick a number to display a result from our string array.
            Console.WriteLine("Welcome! Would you like to see string 1, 2, or 3?");
            string choice1 = Console.ReadLine();
            if (choice1 == "1")
            {
                Console.WriteLine(sentences[0]);
                Console.Read();
            }
            else if (choice1 == "2")
            {
                Console.WriteLine(sentences[1]);
                Console.Read();
            }
            else if (choice1 == "3")
            {
                Console.WriteLine(sentences[2]);
                Console.Read();
            }
            else
            {
                Console.WriteLine("Sorry, you didnt enter one of the options above.");
                Console.Read();
            }

            //This section will have them pick an index from our int array and display it.
            Console.Read();
            Console.WriteLine("Next, pick a number 0 - 2 and I'll repeat it back.");
            string choice2 = Console.ReadLine();
            if (choice2 == "0")
            {
                Console.WriteLine(numbers[0]);
                Console.Read();
            }
            else if (choice2 == "1")
            {
                Console.WriteLine(numbers[1]);
                Console.Read();
            }
            else if (choice2 == "2")
            {
                Console.WriteLine(numbers[2]);
                Console.Read();
            }
            else
            {
                Console.WriteLine("Sorry, you didnt enter one of the options above.");
                Console.Read();
            }


        }
    }
}
