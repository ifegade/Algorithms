using System;
using System.Text.RegularExpressions;

namespace Algorithm
{
    public class StringToIntegerAtoi
    {
        public StringToIntegerAtoi()
        {
             Console.WriteLine(sATOI("-91283472332"));

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
                    return GetInt(str.Substring(i));

            }

            return 0;
        }

        private int GetInt(string value)
        {
            double output = 0;
            int indicator = 1;
            int i = 0;

            if(value[0] == '-' || value[0] == '+')
            {
                if (value[0] == '-')
                    indicator = -1;
                else
                    indicator = 1;
                i++;
            }

            while(i < value.Length)
            {            
                if (value[i] >= '0' && value[i] <= '9')
                {
                    output = output * 10 + (value[i] - '0');
                }
                else
                    break;
                i++;
            }
            if (indicator == -1)
                output = -output;

            if (output > int.MaxValue)
                return int.MaxValue;
            if (output < int.MinValue)
                return int.MinValue;

            return (int) output;
        }

        //int ATOI(string str)
        //{

        //    str = str.Trim();
        //    if (string.IsNullOrEmpty(str) || (str[0] == '+' || str[0] == ' '))
        //        return 0;
        //    string output = string.Empty;
        //    for (int i = 0; i < str.Length; i++)
        //    {

        //        if (i == 0 && !char.IsDigit(str[i]) &&
        //            !char.IsWhiteSpace(str[i]) && str[i] != '-'
        //            || (str.Length == 1 && str[i] == '+') || (str.Length == 1 && str[i] == '-'))
        //        {
        //            output = "0";
        //            break;
        //        }

        //        if (output.Length == 0 && (str[i] == '+' || str[i] == '-'))
        //            output = output + str[i];

        //        if (char.IsDigit(str[i]))
        //            output = output + str[i];

        //        if (i < str.Length - 1 && char.IsDigit(str[i]) && !char.IsDigit(str[i + 1]))
        //            break;
        //    }

        //    int num = 0;

        //    if (int.TryParse(output, out num))
        //        return num;

        //    if (num > int.MaxValue)
        //        return int.MaxValue;

        //    return int.MinValue;
        //}
    }
}
