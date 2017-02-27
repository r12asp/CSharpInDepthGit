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
    public class Leetcode387Tests
    {
        [TestMethod()]
        public void FirstUniqueCharTest()
        {

            Assert.AreEqual(0, Leetcode387.FirstUniqueChar("leetcode"));
            Assert.AreEqual(2, Leetcode387.FirstUniqueChar("loveleetcode"));
        }
    }
}