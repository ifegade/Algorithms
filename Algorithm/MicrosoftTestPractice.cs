using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class MicrosoftTestPractice
    {
        public MicrosoftTestPractice()
        {
        }

        public static void Rever(char[] input, int left, int right)
        {
            if (left > right)
                return;


        }
        public static string ReverseStringRecurssion(Char[] input)
        {
            Rever(input, 0, input.Length - 1);

            return input.ToString();
        }


        public static bool IsMirror(TreeNode node)
        {
            return IsMirror(node, node);
        }

        private static bool IsMirror(TreeNode node1, TreeNode node2)
        {
            if (node1 == null && node2 == null) return true;
            if (node1 == null || node2 == null) return false;

            return node1.val == node2.val && IsMirror(node1.left, node2.right) && IsMirror(node1.right, node2.left);
        }

        public static int IsBadPortion()
        {
            int n = 50;

            int bad = 28;

            int left = 1;
            int right = n;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (mid == bad)
                    return mid;

                if (mid > bad)
                    right = mid;
                else
                    left = mid + 1;
            }

            return 0;
        }
        public static int climbStairs(int n)
        {
            return climbStairs(0, n);
        }
        public static int climbStairs(int i, int n)
        {
            if (i > n)
                return 0;
            if (i == n)
                return 1;
            return climbStairs(i + 1, n) + climbStairs(i + 2, n);
        }


        public static bool IsAnagram(string s, string t)
        {

            //            Time complexity : O(n \log n)O(nlogn).Assume that nn is the length of ss, sorting costs O(n \log n)O(nlogn) and comparing two strings costs O(n)O(n).Sorting time dominates and the overall time complexity is O(n \log n) O(nlogn).

            //Space complexity : O(1)O(1).Space depends on the sorting implementation which, usually, costs O(1)O(1) auxiliary space if heapsort is used.Note that in Java, toCharArray() makes a copy of the string so it costs O(n)O(n) extra space, but we ignore this for complexity analysis because:

            //It is a language dependent detail.
            //It depends on how the function is designed.For example, the function parameter types can be changed to char[].


            if (s.Length != t.Length)
                return false;

            var sArray = s.ToCharArray();
            var tArray = t.ToCharArray();
            Array.Sort(sArray);
            Array.Sort(tArray);

            for (int i = 0; i < sArray.Length; i++)
            {
                if (sArray[i] != tArray[i])
                    return false;
            }

            return true;
        }
        public static int FirstUniqChar(string s)
        {
            s = "loveleetcode";
            Dictionary<Char, int> dictionary = new Dictionary<Char, int>();


            for (int i = 0; i < s.Length; i++)
            {
                if (dictionary.ContainsKey(s[i]))
                    dictionary[s[i]] = dictionary[s[i]] + 1;
                else
                    dictionary.Add(s[i], 1);
            }

            char characterOfInterest = char.MinValue;
            foreach (var item in dictionary)
            {
                if (item.Value == 1)
                {
                    characterOfInterest = item.Key;
                    break;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == characterOfInterest)
                    return i;
            }

            return -1;
        }

        public static int ReverseNumber()
        {

            //            However, this approach is dangerous, because the statement \text{ temp} = \text{ rev} \cdot 10 + \text{ pop}
            //            temp = rev⋅10 + pop can cause overflow.

            //Luckily, it is easy to check beforehand whether or this statement would cause an overflow.

            //To explain, lets assume that \text{ rev}
            //            rev is positive.

            //If temp = \text{ rev} \cdot 10 + \text{ pop}
            //            temp = rev⋅10 + pop causes overflow, then it must be that \text{ rev} \geq \frac{ INTMAX}
            //            { 10}
            //            rev≥ 
            //10
            //INTMAX
            //​	

            //If \text{ rev} > \frac{ INTMAX}
            //            { 10}
            //            rev >
            //10
            //INTMAX
            //​	
            // , then temp = \text{ rev} \cdot 10 + \text{ pop}
            //            temp = rev⋅10 + pop is guaranteed to overflow.
            //If \text{ rev} == \frac{ INTMAX}
            //            { 10}
            //            rev ==
            //10
            //INTMAX
            //​	
            // , then temp = \text{ rev} \cdot 10 + \text{ pop}
            //            temp = rev⋅10 + pop will overflow if and only if \text{ pop} > 7pop > 7

            int x = 1534236469;
            int rev = 0;
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;
                if (rev > Int32.MaxValue / 10 || (rev == Int32.MaxValue / 10 && pop > 7)) return 0;
                if (rev < Int32.MinValue / 10 || (rev == Int32.MinValue / 10 && pop < -8)) return 0;
                // rev = rev  10 + pop;
            }
            return rev;

        }

        public static void ReverseString()
        {
            string name = "ifeoluwa";
            Char[] s = name.ToCharArray();

            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                char temp = s[left];
                s[left++] = s[right];
                s[right--] = temp;
            }

            Console.WriteLine(string.Join(", ", s));
        }
        public static int SingleNumber()
        {
            int[] nums = new int[]
            {
                2,2,1
            };
            Dictionary<int, int> set = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (set.ContainsKey(nums[i]))
                    set[nums[i]] = set[nums[i]] + 1;
                else
                    set.Add(nums[i], 1);
            }
            foreach (var item in set)
            {
                if (item.Value == 1)
                    return item.Key;
            }
            return 0;
        }

        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i])) return true;
                set.Add(nums[i]);
            }

            return false;
        }

        public static void Rotate(int[] nums, int k)
        {
            nums = new int[]
            {
                1,2,3,4,5,6,7
            };
            k = 3;
            int temp, prev;
            for (int i = 0; i < k; i++)
            {
                prev = nums[nums.Length - 1];
                for (int j = 0; j < nums.Length; j--)
                {
                    temp = nums[j];
                    nums[j] = prev;
                    prev = temp;
                }
            }
        }

        public static int MaximumProfit(int[] prices)
        {

            prices = new int[]
         {
                7,6,4,3,1
         };

            int maxProfit = 0;


            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                    maxProfit += prices[i] - prices[i - 1];
            }

            return maxProfit;
        }


        public static int RemoveDuplicate(int[] nums)
        {
            nums = new int[]
            {
                1,1,2
            };

            int lenghtOfArray = 0;
            if (nums.Length == 0)
                return 0;

            int? previous = null;

            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] != previous)
                {
                    nums[lenghtOfArray] = nums[i];
                    lenghtOfArray++;

                }
                previous = nums[i];
            }

            return lenghtOfArray;
        }
    }
}
