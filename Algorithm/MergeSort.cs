using System;
namespace Algorithm
{
    public class MergeSort
    {
        public MergeSort()
        {
            Console.WriteLine(string.Join(", ", MergeSortArray(new int[]
            {
                1,5,3,2,8,7,6,4
            })));
        }

        public int[] MergeSortArray(int[] input)
        {
            if (input.Length <= 1)
                return input;


            int mid = input.Length / 2;

            int[] left;
            int[] right;

            int[] result = new int[input.Length];

            left = new int[mid];

            if (input.Length % 2 == 0)
                right = new int[mid];
            else
                right = new int[mid + 1];


            for (int i = 0; i < mid; i++)
            {
                left[i] = input[i];
            }
            int x = 0;
            for (int i = mid; i < input.Length; i++)
            {
                right[x] = input[i];
                x++;
            }

            left = MergeSortArray(left);
            right = MergeSortArray(right);

            return Merge(left, right);
        }

        private int[] Merge(int[] left, int[] right)
        {
            int[] ret = new int[left.Length + right.Length];

            int leftCursor = 0;
            int rightCursor = 0;
            int retCursor = 0;

            while (leftCursor < left.Length && rightCursor < right.Length)
            {
                if (left[leftCursor] < right[rightCursor])
                    ret[retCursor++] = left[leftCursor++];
                else
                    ret[retCursor++] = right[rightCursor++];
            }

            while (leftCursor < left.Length)
            {
                ret[retCursor++] = left[leftCursor++];
            }

            while (rightCursor < right.Length)
            {
                ret[retCursor++] = right[rightCursor++];
            }

            return ret;
        }
    }
}
