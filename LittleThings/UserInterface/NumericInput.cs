using System;
using System.Collections.Generic;
using System.Text;

namespace LittleThings.UserInterface
{
     class NumericInput : TextInput
    {

        public override void Add(char c)
        {
            //if (Char.isDigit(c)) {
            if (c >= '0' && c <= '9')
            {
                Value += c;
            }
        }
    }
   
            
}
