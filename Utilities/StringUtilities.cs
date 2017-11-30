using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities
{

    public class StringUtilities
    {
        public string str { get; set; }
        

        public StringUtilities(string str, char SearchingChar1, char SearchingChar2)
        {
            this.str = str;
           
        }

        public bool CountChars(char searchingChar1, char searchingChar2, out int numberOfSymb1, out int numberOfSymb2)
        {
            numberOfSymb1 = 0;
            numberOfSymb2 = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (searchingChar1 == str[i])
                {
                    numberOfSymb1++;
                }
                if (searchingChar2 == str[i])
                {
                    numberOfSymb2++;
                }
            }
            if (numberOfSymb1 > 0 || numberOfSymb2 > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
