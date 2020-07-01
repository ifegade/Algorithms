using System;
namespace Algorithm
{
    public class MergeTwoSortedArray
    {
        public MergeTwoSortedArray()
        {
            int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = { 2, 5, 6 };

            Merge(nums1, nums1.Length, nums2, nums2.Length);
        }

        private void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < nums1.Length; i++)
            {
                if (i > nums2.Length)
                    break;


            }

            Console.WriteLine(string.Join(", ", nums1));
        }
    }
}
