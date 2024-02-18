using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_And_Integers_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
           try
            {
                // Starting by creating a list of int to work off of.
                List<int> numbers = new List<int>();
                numbers.Add(2);
                numbers.Add(4);
                numbers.Add(6);
                numbers.Add(8);
                numbers.Add(10);

                //Then, we'll ask the user for a number to divide each int in the list by, and convert their answer to an int.
                Console.WriteLine("What number should we divide by this time?");
                string answer = Console.ReadLine();
                int divideBy = Convert.ToInt32(answer);

                //Then we'll divivde each intem in the list by their choice of number and display the result.
                foreach (int i in numbers)
                {
                    int result = i / divideBy;
                    Console.WriteLine(result);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
                return;
            }

            Console.WriteLine("Try/Catch passed. Moving on.");
            Console.Read();
        }
    }
}
