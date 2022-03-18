using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6Tasks
{
    public class InputChecker
    {
        public static char InputChar()
        {
            string enterMessage = "Enter any symbol: ";
            string quantityError = "You input sould consist of only one symbol!";
            string input;
            do
            {
                Console.Write(enterMessage);
                input = Console.ReadLine();

                if (input.Length > 1 || input.Length == 0)
                {
                    Console.WriteLine(quantityError);
                }
            }
            while (input.Length > 1 || input.Length == 0);

            return input[0];
        }
    }
}
