using System;

namespace _206._Reverse_Linked_List
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
            Console.WriteLine("Hello World!");
        }

        public static ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode res = ReverseList(head.next);
            head.next.next = head;
            head.next = null;

            return res;
        }
    }
}
