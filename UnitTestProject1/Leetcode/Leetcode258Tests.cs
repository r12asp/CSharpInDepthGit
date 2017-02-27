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
    public class Leetcode258Tests
    {
        [TestMethod()]
        public void OneDigitTest()
        {

            Assert.AreEqual(9, Leetcode258.OneDigit(72));
            Assert.AreEqual(2, Leetcode258.OneDigit(2));
            Assert.AreEqual(7, Leetcode258.OneDigit(1456));
        }
    }
}