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
    public class Leetcode409Tests
    {
        [TestMethod()]
        public void LongestPalindromeTest()
        {
            Assert.AreEqual(7, Leetcode409.LongestPalindrome("abccccdd"));
            Assert.AreEqual(7, Leetcode409.LongestPalindrome("xabcccccdd"));
        }
    }
}