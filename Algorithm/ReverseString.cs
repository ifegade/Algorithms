using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
   public  class ReverseString
    {

        public ReverseString()
        {
            
            ReverseWord("the sky is blue");
            ReverseWord("  hello world!  ");
            ReverseWord("a good   example");
            //  reverseString(new char[]
            //  {
            //      'h','e','l','l','o'
            //  });
        }


        public void helper(char[] s, int left, int right)
        {
            if (left >= right) 
                return;
            
            char tmp = s[left];
            
            s[left++] = s[right];
            
            s[right--] = tmp;
            
            helper(s, left, right);
        }

        public void ReverseWord(string s)
        {
            Char[] b = s.ToCharArray();
            int left = 0;
            int right = b.Length - 1;

            //remove leading spaces
            while (left <= right && b[left] == ' ')
            {
                ++left;
            }
            //remove ending spaces
            while (left <= right && b[right] == ' ')
            {
                --right;
            }

            //remove spaces in the middle
            StringBuilder newString = new StringBuilder();
            while (left <= right)
            {
                Char current = b[left];

                if (newString.Length > 0 && newString[newString.Length - 1] != ' ')
                {

                    newString.Append(b[left]);
                }
                else if (current != ' ')
                    newString.Append(b[left]);

                ++left;
            }

            var bArray = newString.ToString().Split(" ");


            left = 0;
            right = bArray.Length - 1;


            while (left < right)
            {
                string temp = bArray[left];

                bArray[left++] = bArray[right];
                bArray[right--] = temp;
            }


            Console.WriteLine(string.Join(" ", bArray));
        }

        public void reverseString(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;


            while (left < right)
            {                
                Char temp = s[left];

                s[left++] = s[right];
                s[right--] = temp;
            }

            Console.WriteLine(string.Join(", ", s));
        }
    }
}
