using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class ValidateBinaryTree
    {
        public ValidateBinaryTree()
        {
            TreeNode node = new TreeNode(5)
            {
                left = new TreeNode(1),
                right = new TreeNode(4)
                {
                    left = new TreeNode(3),
                    right = new TreeNode(6)
                }
            };
            Console.WriteLine(IsValidBSTUsingStack(node));
        }

        public bool IsValidBSTUsingStack(TreeNode node)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            double inOrder = -Double.MaxValue;

            while (stack.Count > 0 || node != null)
            {
                while (node != null)
                {
                    stack.Push(node);
                    node = node.left;
                }


                node = stack.Pop();

                if (node.val <= inOrder)
                    return false;

                inOrder = node.val;
                node = node.right;
            }

            return true;
        }

        //Time complexity O(N) since we visit each node exactly once.
        //Space complexity O(N) since we keep up to the entire tree.
        public bool isValidBST(TreeNode node)
        {
            return helper(node, null, null);
        }

        private bool helper(TreeNode node, int? lower, int? upper)
        {
            if (node == null)
                return true;

            int val = node.val;

            if (lower.HasValue && val <= lower) return false;
            if (upper.HasValue && val >= upper) return false;

            if (!helper(node.right, val, upper)) return false;
            if (!helper(node.left, lower, val)) return false;

            return true;
        }
    }
}
