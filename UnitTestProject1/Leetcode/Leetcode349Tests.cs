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
    public class Leetcode349Tests
    {
        [TestMethod()]
        public void IntersectionOfTwoArraysTest()
        {
            CollectionAssert.AreEqual(new int[] { 2 },
                Leetcode349.IntersectionOfTwoArrays(
                    new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 }));

            CollectionAssert.AreEqual(new int[] { 2,8 },
                Leetcode349.IntersectionOfTwoArrays(
                    new int[] { 9, 9, 2, 1,8,6 }, new int[] { 2, 2, 8 }));
        }
    }
}