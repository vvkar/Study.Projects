using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5Tasks
{
    public class InputChecker
    {
        public static int EnterPositive()
        {
            string enterMessage = "Enter positive number: ";
            string errorMessage = "Incorrect input!";
            string negativeMessage = "Your number should be positive!";
            int result;
            string input;

            while (true)
            {
                Console.Write(enterMessage);

                input = Console.ReadLine();

                if (!int.TryParse(input, out result))
                {
                    Console.WriteLine(errorMessage);
                }
                else if (result <= 0)
                {
                    Console.WriteLine(negativeMessage);
                }
                else break;
            }

            return result;
        }
    }
}
