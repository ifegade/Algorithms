using System;
using System.Text;

namespace Algorithm
{
    public class ValidPalindrome
    {
        public ValidPalindrome()
        {
            Console.WriteLine(IsValidPalindrome("race a car"));
            Console.WriteLine(IsValidPalindrome("madam"));
            Console.WriteLine(IsValidPalindrome("A man, a plan, a canal: Panama"));
        }

        public bool IsValidPalindrome(string s)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetterOrDigit(s[i]))
                    builder.Append(s[i]);
            }

            return builder.ToString().ToLower() == getReversedInput(builder.ToString()).ToLower();

        }

        string getReversedInput(string s)
        {
            int lenght = s.Length - 1;
            string rever = string.Empty;

            while (lenght >= 0)
            {
                rever = rever + s[lenght];
                lenght--;
            }
            Console.WriteLine(rever);
            return rever;
        }

        int getReversed(int s)
        {

            int Reverse = 0;
            while (s > 0)
            {
                int remainder = s % 10;
                Reverse = (Reverse * 10) + remainder;
                s = s / 10;
            }

            return Reverse;
        }
    }
}
