using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp1.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test.Tests
{
    [TestClass()]
    public class Leetcode206Tests
    {
        [TestMethod()]
        public void ReverseLinkedListTest()
        {
            ListNode n1 = new ListNode(1);
            ListNode n2 = new ListNode(2);
            ListNode n3 = new ListNode(3);
            ListNode n4 = new ListNode(4);
            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;

            ListNode nn1 = new ListNode(4);
            ListNode nn2 = new ListNode(3);
            ListNode nn3 = new ListNode(2);
            ListNode nn4 = new ListNode(1);
            nn1.Next = nn2;
            nn2.Next = nn3;
            nn3.Next = nn4;
            IList<int> expectedList = nn1.AllList();

            ListNode reversed =  Leetcode206.ReverseLinkedList(n1);
            IList<int> n1List = reversed.AllList();

            Assert.IsTrue(expectedList.SequenceEqual(n1List));
        }
    }
}