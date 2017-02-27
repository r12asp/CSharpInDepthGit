using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode206
    {
        public static ListNode ReverseLinkedList(ListNode head)
        {
            if (head == null || head.Next == null) return head;

            ListNode newHead = ReverseLinkedList(head.Next);
            head.Next.Next = head;
            head.Next = null;
            return newHead;
        }
    }
}
