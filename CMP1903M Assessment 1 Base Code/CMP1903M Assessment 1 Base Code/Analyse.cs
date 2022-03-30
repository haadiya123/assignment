using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public void analyseText(string text)
        {
            int uppercase = 0, lowercase = 0, vowels = 0, consonants = 0;
            int[] frequency = (new int[(int)char.MaxValue]);
            char[] vowel_list = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            //string text = Console.ReadLine();
            string words = text.Replace(".", "");
            string[] sentences = text.Split('.');
            char[] letter = words.ToCharArray();
            int number_sentence = sentences.Length - 1;
            
            for (int i = 0; i < letter.Length; i++)
            {

                if ((letter[i] >= 'A' && letter[i] <= 'Z') || (letter[i] >= 'a' && letter[i] <= 'z'))
                {
                    if (letter[i] >= 'A' && letter[i] <= 'Z') { uppercase++; }
                    else if (letter[i] >= 'a' && letter[i] <= 'z') { lowercase++; }

                    for (int j = 0; j < vowel_list.Length; j++)
                    {
                        if (letter[i] == vowel_list[j])
                        {
                            vowels++;
                        }

                    }
                    consonants = (uppercase + lowercase) - vowels;

                }

            }

            Console.WriteLine("\nNumber of: \n Sentences:         {0} \n Vowels:            {1} \n Consonants:        {2}  \n Uppercase letters: {3} \n Lowercase letters: {4} \n ", number_sentence, vowels, consonants, uppercase, lowercase);

            string letters = text.ToUpper();


            foreach (char character in letters)
            {
                frequency[(int)character]++;
            }

            for (int i = 0; i < (int)char.MaxValue; i++)
            {
                if (frequency[i] > 0 && char.IsLetterOrDigit((char)i))
                {
                    Console.WriteLine("Frequency of Letter {0}  :    {1} \n", (char)i, frequency[i]);
                }
            }
        } 
    }
}
