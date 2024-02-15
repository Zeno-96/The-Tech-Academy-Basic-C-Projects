using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    class Program
    {
        static void Main()
        {
            //This takes the 3 strings above and concatenates themm into a single sentence, then waits.
            string first = "This is a ";
            string second = "sentence of ";
            string third = "concatenated strings!";
            Console.WriteLine(first + second + third);
            
            //This section takes our string and makes it uppercase.
            string lower = "This sentence used to be lowercase.";
            Console.WriteLine(lower.ToUpper());

            //This section creates a stringbuilder and appends it 3 times. 
            StringBuilder builder = new StringBuilder("Terry");
            builder.Append(", ");
            builder.Append("Chris");
            builder.Append(", Paul.");
            Console.WriteLine(builder);
            Console.Read();
        }
    }
}
