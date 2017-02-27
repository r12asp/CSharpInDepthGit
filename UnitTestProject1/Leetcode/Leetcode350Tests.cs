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
    public class Leetcode350Tests
    {
        [TestMethod()]
        public void IntersectionOfTwoArraysIITest()
        {
            CollectionAssert.AreEqual(new int[] { 2, 2 },
                Leetcode350.IntersectionOfTwoArraysII(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 }));

            CollectionAssert.AreEqual(new int[] { 2, 8 },
                Leetcode350.IntersectionOfTwoArraysII(new int[] { 9, 9, 2, 1, 8, 6 }, new int[] { 2, 2, 8 }));
        }
    }
}