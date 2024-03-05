using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //We'll start by giving the user the current date and time. Then we ask for hour many hours they want to adjust for.
            Console.WriteLine("The current Date and Time is: " + DateTime.Now + "\n And you would like to know the time in how many hours?");
            int hours = Convert.ToInt32(Console.ReadLine());

            //Then we'll get the current time, add the hours from the user, and print that new time
            DateTime currentTime = DateTime.Now;
            DateTime adjustedTime = currentTime.AddHours(hours);
            Console.WriteLine("In " + hours + " hour(s) it will be "+ adjustedTime);
            Console.Read();
        }
    }
}
