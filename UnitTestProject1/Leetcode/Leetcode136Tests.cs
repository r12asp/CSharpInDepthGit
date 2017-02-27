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
    public class Leetcode136Tests
    {
        [TestMethod()]
        public void SingleNumberTest()
        {
            int[] a1 = { 1, 2, 2, 1, 3 };
            int[] a2 = { 44, 66, 88, 88, 66 };
            int[] a3 = { 222, 222, 4, 4, 8888, 8888, 9 };

            Assert.AreEqual(3, Leetcode136.SingleNumber(a1));
            Assert.AreEqual(44, Leetcode136.SingleNumber(a2));
            Assert.AreEqual(9, Leetcode136.SingleNumber(a3));
        }
    }
}