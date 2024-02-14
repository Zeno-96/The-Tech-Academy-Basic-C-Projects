using System;

namespace Boolean_Logic_Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Insurance Approval Questionnaire \n To start, please enter your age in numbers:");
            string age = Console.ReadLine();
            int usersAge = int.Parse(age);
            //This section welecomes the user and askes for thier age. Then parses it to an int.

            Console.WriteLine("Have you ever had a DUI? (Please enter \"yes\" or \"no\") ");
            string dui = Console.ReadLine();
            // This section ask for a yes or no.

            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int usersTickets = int.Parse(tickets);
            //This section asks for a number of tickets and parses it to an int for later.

            bool qualified = (usersAge > 15 && dui == "no" && usersTickets < 3);
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualified);
            Console.Read();
        }
    }
}
