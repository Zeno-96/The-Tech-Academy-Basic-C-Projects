using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //We'll start by getting a number from the user and loging that number to a .txt file.
            Console.WriteLine("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\bmort\Documents\GitHub\The Tech Academy Basic C# Projects\Basic_C#_Programs\Input_Assignment\Logs\logs.txt", true))
            {
                file.WriteLine(number);
            }

            //Then we'll print that text file back to the user.
            using (StreamReader logReader = new StreamReader(@"C:\Users\bmort\Documents\GitHub\The Tech Academy Basic C# Projects\Basic_C#_Programs\Input_Assignment\Logs\logs.txt"))
            {
                string log = logReader.ReadToEnd();
                Console.WriteLine("You entered: " + log);
                Console.Read();
            }  
        }
    }
}
