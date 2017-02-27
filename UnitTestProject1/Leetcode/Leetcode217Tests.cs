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
    public class Leetcode217Tests
    {
        [TestMethod()]
        public void ContainsDuplicateTest()
        {
            Assert.AreEqual(true, Leetcode217.ContainsDuplicate(new int[] { 2, 3, 4, 4 }));
            Assert.AreEqual(false, Leetcode217.ContainsDuplicate(new int[] { 2, 3, 0, 4 }));
        }
    }
}