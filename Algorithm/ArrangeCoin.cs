using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class ArrangeCoin
    {
        public ArrangeCoin()
        {
            Console.WriteLine(UsingBinanrySearch(5));
        }


        private int UsingBinanrySearch(int n)
        {
            long left = 0;
            long right = n;
            long k = 0;
            long current = 0;
            while (left <= right)
            {
                k = left + (right - left) / 2;

                current = k * (k + 1) / 2;

                if (current == n) return (int)k;

                if (n < current)
                    right = k - 1;
                else
                    left = k + 1;
            }

            return (int)right;
        }

        private int completeStep(int n)
        {
            int levelCounter = 0;
            int row = 1;

            if (n == 0)
                return 0;

            while (n >= row)
            {
                n = n - row;
                row += 1;
                levelCounter += 1;
            }

            return levelCounter;

            //will fail for large numbers
            // return (int)(Math.sqrt(2 * (long)n + 0.25) - 0.5);


            //not efficient enough
            //int count = 0;
            //int numberOfStaris = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (count == n)
            //        {
            //            return numberOfStaris;
            //        }

            //        count++;
            //    }
            //    numberOfStaris++;
            //}

            //return numberOfStaris;
        }
    }
}
