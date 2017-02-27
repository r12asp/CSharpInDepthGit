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
    public class Leetcode383Tests
    {
        [TestMethod()]
        public void CanConstructTest()
        {
            Assert.IsFalse(Leetcode383.CanConstruct("a", "b"));
            Assert.IsFalse(Leetcode383.CanConstruct("aa", "ab"));
            Assert.IsTrue(Leetcode383.CanConstruct("aa", "aab"));
            Assert.IsTrue(Leetcode383.CanConstruct("ttaca", "tatabc"));
        }
    }
}