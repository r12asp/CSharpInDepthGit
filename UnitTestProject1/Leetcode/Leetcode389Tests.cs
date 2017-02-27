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
    public class Leetcode389Tests
    {
        [TestMethod()]
        public void FindTheDifferenceTest()
        {
            string t1 = "abc",t2="abce";
            Assert.AreEqual('e', Leetcode389.FindTheDifference(t1, t2));
        }
    }
}