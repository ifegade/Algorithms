using System;
namespace Algorithm
{
    public class ReverseList
    {
        public ReverseList()
        {
            ListNode head = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                        }
                    }
                }
            };
            HelperClasses.Display(ReverseListFunction(head));
        }



        public ListNode ReverseListFunction(ListNode head)
        {
            HelperClasses.Display(head);

            ListNode current = head;
            ListNode prev = null;
            while (current != null)
            {
                ListNode nextTemp = current.next;
                current.next = prev;
                prev = current;
                current = nextTemp;
            }

            return prev;
        }
    }
}
