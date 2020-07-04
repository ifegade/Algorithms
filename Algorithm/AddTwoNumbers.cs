using System;
namespace Algorithm
{
    public class AddTwoNumbers
    {
        public AddTwoNumbers()
        {
            ListNode l1 = new ListNode(2)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(3)
                }
            };

            ListNode l2 = new ListNode(5)
            {
                next = new ListNode(6)
                {
                    next = new ListNode(4)
                }
            };
            HelperClasses.Display(AddTwoNumbersFunction(l1, l2));

        }

        public ListNode AddTwoNumbersFunction(ListNode l1, ListNode l2)
        {
            ListNode temp = new ListNode(0);
            ListNode one = l1;
            ListNode two = l2;
            int pending = 0;
            ListNode current = temp;

            while (one != null || two != null)
            {
                int getFirstValue = one == null ? 0 : one.val;
                int getSecondValue = two == null ? 0 : two.val;

                int sum = getFirstValue + getSecondValue + pending;

                pending = sum / 10;

                current.next = new ListNode(sum % 10);
                current = current.next;

                if (one != null)
                    one = one.next;
                if (two != null)
                    two = two.next;
            }
            if (pending > 0)
                current.next = new ListNode(pending);

            return temp.next;
        }

        ListNode ReverseNode(ListNode node)
        {
            HelperClasses.Display(node);
            ListNode current = node;
            ListNode prev = null;

            while (current != null)
            {
                ListNode temp = current.next;

                current.next = prev;
                prev = current;
                current = temp;

            }
            HelperClasses.Display(prev);
            return prev;
        }


    }
}
