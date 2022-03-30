using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string text = "nothing";
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            //string text = "*";
            //do

            Console.WriteLine("Type in your sentence and end entry with *: ");
            string text = Console.ReadLine();
            // Text_analysis(text);
            // while (text[text.Length - 1] != "*");

            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            //namespace ReadingFile
            string text = System.IO.File.ReadAllText(@$"../../../../../Files/{fileName}");
            // Text_analysis(text);
            return text;
        }

    }
}
