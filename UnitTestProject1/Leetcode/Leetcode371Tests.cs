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
    public class Leetcode371Tests
    {
        [TestMethod()]
        public void SumTest()
        {
            Assert.AreEqual(3, Leetcode371.Sum(1, 2));
            Assert.AreEqual(12, Leetcode371.Sum(10, 2));
            Assert.AreEqual(2010, Leetcode371.Sum(10, 2000));
        }
    }
}