using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Daily_Report
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy. \nStudent Daily Report.");
                //This line prints the startup text.

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
                //This allows users to enter a name.

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            //This allows users to list the course they are working on. 

            Console.WriteLine("What page number?");
            string page = Console.ReadLine();
            //This line asks them to specify which page number they are at.

            Console.WriteLine("Do you need help with anything? (Please answer \"true\" or \"false\".)");
            string help = Console.ReadLine();
            //Gives the user the opportunity to ask for help.

            Console.WriteLine("Were there any positive experiences you would like to share?");
            string positives = Console.ReadLine();
            //Gives a secion for sharing their thoughts

            Console.WriteLine("Is there any other feedback you would like to provide?");
            string feedback = Console.ReadLine();
            //Gives a secion for sharing their feedback

            Console.WriteLine("How many hous did you study today?");
            string hours = Console.ReadLine();
            //Asks how long they studied

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
