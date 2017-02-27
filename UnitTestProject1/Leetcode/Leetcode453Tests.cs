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
    public class Leetcode453Tests
    {
        [TestMethod()]
        public void MinMovesTest()
        {
            Assert.AreEqual(3, Leetcode453.MinMoves(new int[] { 1, 2, 3 }));
            Assert.AreEqual(4, Leetcode453.MinMoves(new int[] { 1, 5, 1 }));
            Assert.AreEqual(4, Leetcode453.MinMoves(new int[] { 1, 3, 3 }));
        }
    }
}