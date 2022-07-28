using System;

namespace _876._Middle_of_the_Linked_List
{
    class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        static void Main(string[] args)
        {
        }

        public ListNode MiddleNode(ListNode head)
        {
            ListNode pSlow = head, pFast = head;
            while (pFast != null && pFast.next != null)
            {
                pFast = pFast.next.next;
                pSlow = pSlow.next;
            }
            return pSlow;
        }
    }
}
