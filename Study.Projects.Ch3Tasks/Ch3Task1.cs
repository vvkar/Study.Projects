using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Study.Projects.Ch3Tasks
{
    /// <summary>
    /// Write a program where user enters a number and the program checks 
    /// if the number is divisible by 3 and 7. The results of the check should be 
    /// displayed in a dialog box. Use exception handling.
    /// </summary>
    internal class Ch3Task1
    {
        static void Main()
        {
            var prompt = "Enter a number";

            var title = "Number check";
            
            DialogResult resultButton;
            
            bool exitCheck;
            
            do
            {
                var input = Interaction.InputBox(prompt, title);

                try
                {
                    int number = int.Parse(input);

                    if (number % 3 == 0)
                    {
                        resultButton = MessageBox.Show("Your number divisable by 3",
                            title,
                            MessageBoxButtons.RetryCancel);
                    }
                    else if (number % 7 == 1)
                    {
                        resultButton = MessageBox.Show("Your number divisable by 7",
                            title,
                            MessageBoxButtons.RetryCancel);
                    }
                    else
                    {
                        resultButton = MessageBox.Show("Your number is not divisable by 3 or by 7",
                            title,
                            MessageBoxButtons.RetryCancel);
                    }

                    exitCheck = resultButton == DialogResult.Cancel;

                }
                catch (Exception ex)
                {
                    resultButton = MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Error);

                    exitCheck = (resultButton == DialogResult.Cancel);
                }
            }
            while (!exitCheck);

            MessageBox.Show("Good bye", "End of program", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }
}
