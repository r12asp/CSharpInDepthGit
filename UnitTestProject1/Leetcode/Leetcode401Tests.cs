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
    public class Leetcode401Tests
    {
        [TestMethod()]
        public void BinaryWatchTest()
        {
            string[] expected = new string[] { "1:00", "2:00", "4:00", "8:00", "0:01", "0:02", "0:04", "0:08", "0:16", "0:32" };
            CollectionAssert.AreEquivalent(expected, Leetcode401.BinaryWatch(1));
        }
    }
}