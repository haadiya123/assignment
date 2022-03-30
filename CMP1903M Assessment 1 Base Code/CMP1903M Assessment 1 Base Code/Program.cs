//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();
            string text = "some text";
            Console.WriteLine("Type: \n 1 - to input via keyboard \n 2 - to read from file ");
            string option = Console.ReadLine();

            Input options = new Input();
            if (option == "1")
            {
                text = options.manualTextInput();
            }
            else if (option == "2")
            {
                Console.WriteLine("PLease enter the filename");
                string filename = Console.ReadLine();
                text = options.fileTextInput(filename);
            }

            Analyse whatever = new Analyse();
            whatever.analyseText(text);
            
            
            Console.WriteLine(text);
            Console.Read();

        }
        
            //Create 'Input' object
            //Get either manually entered text, or text from a file


            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method


            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?

        
        }
}
