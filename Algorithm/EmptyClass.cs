using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class EmptyClass
    {
        public EmptyClass()
        {
            //Console.WriteLine(LoginDistance(new int[]
            //{
            //   1, 5, 5, 2, 6
            //}));

            Console.WriteLine(StringSolution("AABBBB"));
            //Console.WriteLine(this.StringSolution(new[]
            //{

            //    //4,2,0
            //  //  3,4,3,0,2,2,3
            //}));
        }

        public int LoginDistance(int[] blocks)
        {
            return LongestDistance(blocks, int.MinValue, 0); ;
        }

        public int LongestDistance(int[] nums, int prev, int position)
        {
            if (position == nums.Length)
            {
                return 0;
            }
            int numberOfRowsDone = 0;
            if (nums[position] >= prev)
            {
                numberOfRowsDone = 1 + LongestDistance(nums, nums[position], position + 1);
            }
            return Math.Max(numberOfRowsDone, LongestDistance(nums, prev, position + 1));
        }
        public int StringSolution(string S)
        {

            if (string.IsNullOrEmpty(S))
                return 0;

            Char characterOfInterest = S[0];

            bool? compare = null;

            if (characterOfInterest == 'A')
                compare = 'A' > 'B';
            else
                compare = 'B' > 'A';

            int count = 0;
            int countNext = 0;
            for (int i = 1; i < S.Length; i++)
            {
                if (S[i] == S[i - 1] && characterOfInterest == S[i])
                {
                    continue;
                }

                int status = S[i].CompareTo(S[i - 1]);


                bool s = status > 0 ? true : false;

                if (s != compare.Value)
                    count++;

            }
            return count;
        }
        public int solution(int[] ranks)
        {
            int count = 0;
            HashSet<int> theRanks = new HashSet<int>();

            for (int i = 0; i < ranks.Length; i++)
            {
                theRanks.Add(ranks[i]);
            }

            for (int i = 0; i < ranks.Length; i++)
            {
                if (theRanks.Contains(ranks[i] + 1))
                    count++;
            }
            return count;
        }

    }
}
