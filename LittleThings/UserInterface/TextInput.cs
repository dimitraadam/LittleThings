﻿/*
User interface contains two types of user input controls: TextInput, which accepts all characters and NumericInput, which accepts only digits.

Implement the class TextInput that contains:

    Public method void Add(char c) - adds the given character to the current value
    Public method string GetValue() - returns the current value

Implement the class NumericInput that:
    Inherits TextInput
    Overrides the Add method so that each non-numeric character is ignored

For example, the following code should output "10":

TextInput input = new NumericInput();
input.Add('1');
input.Add('a');
input.Add('0');
Console.WriteLine(input.GetValue());
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace LittleThings.UserInterface
{
   class TextInput
    {
        protected string Value;

        public TextInput()
        {
            Value = "";
        }

        public virtual void Add(char c)
        {
            Value += c;
        }

        public string GetValue()
        {
            return Value;
        }

    }
}
