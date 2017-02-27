using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode237
    {
        public static void DeleteNode(ListNode node)
        {
            node.val = node.Next.val;
            node.Next = node.Next.Next;
        }
    }
}
