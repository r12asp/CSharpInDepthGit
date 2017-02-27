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
    public class Leetcode459Tests
    {
        [TestMethod()]
        public void RepeatedSubstringTest()
        {
            Assert.IsTrue(Leetcode459.RepeatedSubstring("abcabcabc"));
            Assert.IsFalse(Leetcode459.RepeatedSubstring("abii"));
        }
    }
}