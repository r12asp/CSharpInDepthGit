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
    public class Leetcode283Tests
    {
        [TestMethod()]
        public void MoveZeroesTest()
        {
            int[] a1 = { 0, 1, 0, 3, 12 };
            int[] a2 = { 1, 3, 12, 0, 0 };

            Leetcode283.MoveZeroes(a1);

            CollectionAssert.AreEqual(a2, a1);
        }
    }
}