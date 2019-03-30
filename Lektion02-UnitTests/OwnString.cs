using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion2
{
    public class OwnString
    {
        public int CharAt(char[] str, char c)
        {
            int i = 0;
            foreach (var ch in str)
            {
                if (ch == c)
                {
                    return i;
                }
                ++i;
            }
            return 0;
        }

        public int Length(char[] str)
        {
            int num_of_chars = 0;
            foreach (var ch in str)
            {
                num_of_chars++;
            }

            return num_of_chars;
        }

        public char[] SubString(char[] str, int start, int end)
        {
            // Hvor meget plads vi skal allokere i vores returnChar
            int size = end - start + 1;

            char[] returnChar = new char[size];
            int index = 0;
            int current = 0;

            foreach (var ch in str)
            {
                if (current >= start && current <= end)
                {
                    returnChar[index] = ch;
                    index++;
                }

                current++;
            }

            return returnChar;
        }

        
        public char[] ToLowerCase(char[] str)
        {
            foreach (var ch in str)
            {
              char.ToLower(ch);
            }

            return str;
        }
        
    }
}
