using System;

namespace Shipping_Quote_Project
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            // Welcome Text

            Console.WriteLine("Please enter your packages weight in whole numbers:");
            string weight = Console.ReadLine();
            int packageWeight = Convert.ToInt32(weight);
            // This section asks for the package weight and converts it to an int variable.

            if (packageWeight > 50)
            {
                Console.WriteLine("Sorry, your package is too big to be shipped via Package Express.");
                Console.Read();
                // This section cancels the quote if the package is heavier than 50.
            }
            else
            {
                Console.WriteLine("Please enter your packages Length in whole numbers:");
                string length = Console.ReadLine();
                int packageLength = Convert.ToInt32(length);

                Console.WriteLine("Please enter your packages Width in whole numbers:");
                string width = Console.ReadLine();
                int packageWidth = Convert.ToInt32(width);

                Console.WriteLine("Please enter your packages Height in whole numbers:");
                string height = Console.ReadLine();
                int packageHeight = Convert.ToInt32(height);
                //This section asks for the remaining dimensions and converts them to an int variable.

                if (packageLength + packageWidth + packageHeight > 50)
                {
                    Console.WriteLine("Sorry, your package is too big to be shipped via Package Express.");
                    Console.Read();
                    // This section cancels the quote if the package dimensions are greater than 50.
                }
                else
                {
                    decimal dimensions = (packageLength * packageWidth * packageHeight * packageWeight);
                    decimal quote = dimensions / 100;
                    Console.WriteLine("Your estimated shipping total is: $" + quote);
                    Console.Read();
                }
            }
        }
    }
}
