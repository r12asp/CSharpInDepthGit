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
    public class Leetcode326Tests
    {
        [TestMethod()]
        public void PowerOfTreeTest()
        {
            Assert.IsFalse(Leetcode326.PowerOfTree(12));
            Assert.IsTrue(Leetcode326.PowerOfTree(27));
        }
    }
}