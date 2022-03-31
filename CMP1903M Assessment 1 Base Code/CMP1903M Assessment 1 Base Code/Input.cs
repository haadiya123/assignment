using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        string text = "empty"; 
        public string manualTextInput()
        {
            //gets user input to analyse text if option 1 is chosen, which is saves in text, and returned
            Console.WriteLine("Type in your sentence and end entry with *: ");
            text = Console.ReadLine();
            return text;
        }
        public string fileTextInput(string fileName)
        {
            //while loop for error handling in case the file does not exist
            string error = ("Error, the file does not exist. Please rewrite the filename.");
            while (true)
            {
                try
                {
                    text = System.IO.File.ReadAllText(@$"../../../../../Files/{fileName}");
                    break;
                }
                catch
                {
                    Console.WriteLine(error);
                    fileTextInput(Console.ReadLine());
                }
            }
            return text;
        }

    }
}
