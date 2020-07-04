using System;
namespace Algorithm
{
    public class HelperClasses
    {


        public static void Display(ListNode node)
        {
            ListNode current = node;
            while (current != null)
            {
                Console.Write(current.val);
                current = current.next;
            }
            Console.WriteLine();
        }
    }

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
}
