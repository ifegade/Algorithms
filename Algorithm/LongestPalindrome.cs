using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class LongestPalindrome
    {

        public LongestPalindrome()
        {
            Console.WriteLine(LongestPalindromeString("babad"));
            Console.WriteLine(LongestPalindromeString("cbbd"));
        }
        public string LongestPalindromeString(string s)
        {
            if (s == null || s.Length < 1)
                return string.Empty;
            int startPointer = 0;
            int endPointer = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int lenght = Math.Max(getCenter(s, i, i), getCenter(s, i, i + 1));
                if(lenght > endPointer - startPointer)
                {
                    startPointer = i - (lenght - 1) / 2;
                    endPointer = i + lenght / 2;
                }
            }
            return s.Substring(startPointer, endPointer + 1);
        }

        int getCenter(String value, int left, int right)
        {
            int S = left;
            int R = right;
            while(left >= 0 && right < value.Length && value[S] == value[R])
            {
                S--;
                R++;
            }

            return S - R - 1;
        }
    }
}
