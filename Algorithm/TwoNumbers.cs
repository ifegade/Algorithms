using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class TwoNumbers
    {
        public TwoNumbers()
        {
            Console.WriteLine(string.Join(", ", GetTwoNumbers(new int[]
            {
                2,7,11,15
            }, 9)));
        }

        public int[] GetTwoNumbers(int[] nums, int target)
        {
            Dictionary<int, int> theMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!theMap.ContainsKey(nums[i]))
                    theMap.Add(nums[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (theMap.ContainsKey(complement) && theMap[complement] != i)
                    return new int[]
                    {
                        i, theMap[complement]
                    };
            }


            return new int[]{
            };

            //            Time complexity : O(n)O(n).We traverse the list containing nn elements exactly twice. Since the hash table reduces the look up time to O(1)O(1), the time complexity is O(n) O(n).

            //Space complexity : O(n)O(n).The extra space required depends on the number of items stored in the hash table, which stores exactly nn elements.
        }
    }
}
