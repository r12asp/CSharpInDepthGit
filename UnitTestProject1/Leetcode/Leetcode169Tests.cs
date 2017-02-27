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
    public class Leetcode169Tests
    {
        [TestMethod()]
        public void MajorityElementTest()
        {
            Assert.AreEqual(2, Leetcode169.MajorityElement(new int[] { 1, 2, 2 }));
            Assert.AreEqual(2, Leetcode169.MajorityElement(new int[] { 1, 2, 2,4,5,5,2,2,2 }));
            Assert.AreEqual(2, Leetcode169.MajorityElement(new int[] { 1, 2, 2 ,2,2,9,9}));
        }
    }
}