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

            HashSet<Char> open = new HashSet<char>();
            open.Add('[');
            open.Add('(');
            open.Add('{');

            Stack<char> braces = new Stack<char>();
            
            for(int i = 0; i < s.Length; i++)
            {
                if (open.Contains(s[i]))
                {
                    braces.Push(s[i]);
                    continue;
                }
                if (braces.Count == 0)
                    return false;
                Char last = braces.Pop();

                if((s[i] == ']' && last != '[') || (s[i] == '}' && last != '{') || (s[i] == ')' && last != '('))
                {
                   return false;
                }            
            }
            return braces.Count == 0;
        }
    }
}
