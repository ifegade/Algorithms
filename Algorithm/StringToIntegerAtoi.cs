using System;
using System.Text.RegularExpressions;

namespace Algorithm
{
    public class StringToIntegerAtoi
    {
        public StringToIntegerAtoi()
        {
            // Console.WriteLine(ATOI("    -42"));

            Console.WriteLine(sATOI("   42"));


            Console.WriteLine(sATOI("4193 with words"));

            Console.WriteLine(sATOI("words and 987"));
            Console.WriteLine(sATOI("-91283472332"));
        }


        int sATOI(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsWhiteSpace(str[i]))
                    return convertToInteger(str.Substring(i));

            }

            return 0;
        }

        private int convertToInteger(string v)
        {
            return 0;
        }

        int ATOI(string str)
        {

            str = str.Trim();
            if (string.IsNullOrEmpty(str) || (str[0] == '+' || str[0] == ' '))
                return 0;
            string output = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {

                if (i == 0 && !char.IsDigit(str[i]) &&
                    !char.IsWhiteSpace(str[i]) && str[i] != '-'
                    || (str.Length == 1 && str[i] == '+') || (str.Length == 1 && str[i] == '-'))
                {
                    output = "0";
                    break;
                }

                if (output.Length == 0 && (str[i] == '+' || str[i] == '-'))
                    output = output + str[i];

                if (char.IsDigit(str[i]))
                    output = output + str[i];

                if (i < str.Length - 1 && char.IsDigit(str[i]) && !char.IsDigit(str[i + 1]))
                    break;
            }

            int num = 0;

            if (int.TryParse(output, out num))
                return num;

            if (num > int.MaxValue)
                return int.MaxValue;

            return int.MinValue;
        }
    }
}
