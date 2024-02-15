using System;

namespace Loop_Assignment
{
    class Program
    {
        static void Main()
        {
            string name = "brandon";
            bool check = false;

            while (check == false)
            {
                Console.WriteLine("Please guess my name:");
                string guess = Console.ReadLine();

                if (guess == name)
                {
                    Console.WriteLine("Correct!");
                    check = true;
                    Console.Read();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, try again.");
                    check = false;
                }
            }
            
        }
    }
}
