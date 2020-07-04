using System;
namespace Algorithm
{
    public class MaximumSubArray
    {
        public MaximumSubArray()
        {
            Console.WriteLine(MaxSubArray(new int[]
            {
                -2,1,-3,4,-1,2,1,-5,4
            }));
        }


        public int MaxSubArray(int[] nums)
        {
            int max = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] > 0)
                    nums[i] += nums[i - 1];
                max = Math.Max(nums[i], max);
            }

            return max;
        }


        //    public int Divider(int[] n, int start, int end)
        //    {
        //        Console.WriteLine(string.Join(", ", n));
        //        if (start == end)
        //            return 0;

        //        int midPoint = (start + end) / 2;

        //        int[] left = new int[midPoint];
        //        int[] right;

        //        if (((start + end) % 2) == 0)
        //            right = new int[midPoint];
        //        else
        //            right = new int[midPoint + 1];

        //        for (int i = 0; i < midPoint; i++)
        //        {
        //            left[i] = n[i];
        //        }

        //        int x = 0;

        //        for (int i = midPoint; i < end; i++)
        //        {
        //            right[x] = n[i];
        //            x++;
        //        }

        //        int leftSum = Divider(left, start, midPoint);
        //        int rightSum = Divider(right, midPoint + 1, end);

        //        int crossSum = CrossSum(n, start, end, midPoint);
        //        return Math.Max(Math.Max(leftSum, rightSum), crossSum);
        //    }

        //    private int CrossSum(int[] n, int start, int end, int midPoint)
        //    {
        //        if (start == end)
        //            return n[start];

        //        int leftSubSum = int.MinValue;
        //        int currentSum = 0;
        //        for (int i = midPoint; i > start - 1; --i)
        //        {
        //            currentSum += n[i];
        //            leftSubSum = Math.Max(leftSubSum, currentSum);
        //        }


        //        int rightSubSum = int.MinValue;
        //        currentSum = 0;
        //        for (int i = midPoint + 1; i < end + 1; ++i)
        //        {
        //            currentSum += n[i];
        //            rightSubSum = Math.Max(rightSubSum, currentSum);
        //        }

        //        return leftSubSum + rightSubSum;
        //    }

        //}
    }
}