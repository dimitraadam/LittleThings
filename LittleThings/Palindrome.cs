/*
A palindrome is a word that reads the same backward or forward.
Write a function that checks if a given word is a palindrome. Character case should be ignored.
For example, IsPalindrome("Deleveled") should return true as character case should be ignored, resulting in "deleveled", which is a palindrome since it reads the same backward and forward.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace LittleThings
{
    using System;

    class Palindrome
    {
        public bool IsPalindrome(string word)

        {
            word = word.ToLower();
            for (int i = 0; i <= word.Length - 1; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return false;
                }

            }
            return true;

        }

    }
}
