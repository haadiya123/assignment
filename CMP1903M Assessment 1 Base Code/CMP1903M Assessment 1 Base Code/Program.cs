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
            //main menu, initially displayed to get user's choice of input
            string text = "empty";
            Input options = new Input();
            //error handling
            string error = ("invalid input,");
            while (true)
            {
                Console.WriteLine("Type: \n 1 - to input via keyboard \n 2 - to read from file ");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    //redirecting depending on userinput, option 1 to manually get user input from keyboard
                    text = options.manualTextInput();
                    break;
                }
                else if (option == "2")
                {
                    //option 2 reads a text file to be analysed, user has to type in the file name, in this case it's called t.txt
                    Console.WriteLine("PLease enter the filename");
                    string filename = Console.ReadLine();
                    text = options.fileTextInput(filename);
                    break;
                }
                else
                {
                    Console.WriteLine(error);
                }
            }
            

            Analyse text_analysis = new Analyse();
            text_analysis.analyseText(text);
            
            
            Console.WriteLine(text);
            Console.Read();

        }
    }
}
