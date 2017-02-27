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
    public class Leetcode415Tests
    {
        [TestMethod()]
        public void AddStringsTest()
        {
            Assert.AreEqual("1311", Leetcode415.AddStrings("1155", "156"));
        }
    }
}