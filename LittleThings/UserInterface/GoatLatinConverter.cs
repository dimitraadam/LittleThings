using System;
using System.Collections.Generic;
using System.Text;

namespace LittleThings.UserInterface
{
    static class GoatLatinConverter
    {

        public static string ToGoatLatin(string s)
        {
            List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };

            //if (lang == "el_GR")
            //{
            //    vowels = new List<char>() { 'α', 'ε', 'η', 'ι', 'ο', 'υ' };
            //}
            //else if (lang == "en_US")
            //{
            //    vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };

            //}

           
            string[] ArrayOfWords = s.Split(' ');

           
            StringBuilder GoatLatinedString = new StringBuilder();

            for (int i = 0; i < ArrayOfWords.Length; i++)
            {
                StringBuilder GoatLatinedCurrentWord = new StringBuilder();

                string currentWord = ArrayOfWords[i];

                if (vowels.Contains(currentWord[0]))
                {
                    GoatLatinedCurrentWord.Append(currentWord);
                                       
                }
                else {

                    GoatLatinedCurrentWord.Append(currentWord.Substring(1));
                    GoatLatinedCurrentWord.Append(currentWord[0]);
                    
                }

                GoatLatinedCurrentWord.Append("ma");

                for (int j = 0; j <= i; j++)
                {
                    GoatLatinedCurrentWord.Append("a");
                }

                GoatLatinedString.Append(GoatLatinedCurrentWord + " ");
            }

            return GoatLatinedString.ToString();




        }
    }
}
