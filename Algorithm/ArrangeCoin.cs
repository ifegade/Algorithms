using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class ArrangeCoin
    {
        public ArrangeCoin()
        {
            Console.WriteLine( completeStep(5));
        }

        private int completeStep(int num)
        {
            Stack<int> rows = new Stack<int>();
            int count = 0;
            int numberOfStaris = 0;
            for(int i = 1; i <= num; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if(count == num)
                    {
                            return numberOfStaris;
                    }
                    Console.Write("*");                   
                    count++;
                }
                numberOfStaris++;
                Console.WriteLine();
            }

            return numberOfStaris;
        }
    }
}
