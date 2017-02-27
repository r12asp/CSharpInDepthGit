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
    public class Leetcode455Tests
    {
        [TestMethod()]
        public void ContentedNumTest()
        {
            Assert.AreEqual(1, Leetcode455.ContentedNum(new int[] { 1, 2, 3 }, new int[] { 1, 1 }));
            Assert.AreEqual(2, Leetcode455.ContentedNum(new int[] { 1, 2 }, new int[] { 1,2,3 }));
        }
    }
}