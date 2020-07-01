using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class ValidParentheses
    {
        public ValidParentheses()
        {
            
            Console.WriteLine(IsValid("){"));
            Console.WriteLine(IsValid("(("));
            Console.WriteLine(IsValid("([)]"));
            Console.WriteLine(IsValid("()"));
            Console.WriteLine(IsValid("()[]{}"));
            Console.WriteLine(IsValid("(]"));
        }

        public bool IsValid(string s)
        {
            if (s == "")
                return true;

            if (s.Length <= 1)
                return false;

            Dictionary<Char, Char> open = new Dictionary<Char, Char>();
            open.Add('[',']');
            open.Add('(',')');
            open.Add('{','}');

            Stack<char> braces = new Stack<char>();
            
            for(int i = 0; i < s.Length; i++)
            {
                if (open.ContainsKey(s[i]))
                {
                    braces.Push(s[i]);
                    continue;
                }
                if (braces.Count == 0)
                    return false;
                

                if(open.ContainsKey(s[i]) && s[i]  == open[s[i]])
                {
                   return false;
                }            
            }
            return braces.Count == 0;
        }
    }
}
