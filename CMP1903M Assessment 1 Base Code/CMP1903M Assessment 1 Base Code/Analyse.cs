using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        public void analyseText(string text)
        {
            //list of variables to be used
            //I found it more efficient to output the values in this function rather than returning it
            int uppercase = 0, lowercase = 0, vowels = 0, consonants = 0;
            int[] frequency = (new int[(int)char.MaxValue]);
            // made a list of vowels to compare to the text file
            char[] vowel_list = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            //string text = Console.ReadLine();
            string words = text.Replace(".", "");
            string[] sentences = text.Split('.');
            //split each sentence to words and placing them in an array
            char[] letter = words.ToCharArray();
            int number_sentence = sentences.Length - 1;
            
            //going through the array, letter by letter and analysing
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
            // converting every letter to capital so each letter isn't counted twice separately due to being lower and uppercase
            string letters = text.ToUpper();

            //counting the frequency of each letter, i found this method more efficient than the original one.
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
