using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class LinkedListCycle
    {
        public LinkedListCycle()
        {

            ListNode head = new ListNode(3)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(0)
                    {
                        next = new ListNode(-4)
                    }
                }
            };
            Console.WriteLine(LinkedListFunction(head));
        }

        private bool LinkedListFunction(ListNode head)
        {
            HashSet<ListNode> list = new HashSet<ListNode>();

            while (head != null)
            {
                if (list.Contains(head))
                    return true;
                else
                    list.Add(head);
                head = head.next;
            }

            return false;
        }
    }
}
