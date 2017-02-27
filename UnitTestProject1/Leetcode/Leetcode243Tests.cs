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
    public class Leetcode243Tests
    {
        [TestMethod()]
        public void ShortestDistanceTest()
        {
            string[] words1 = { "practice", "makes", "perfect", "coding", "makes" };
            string word11 = "coding",word12="practice";
            string word21 = "makes", word22 = "coding";

            Assert.AreEqual(3, Leetcode243.ShortestDistance(words1, word11, word12));
            Assert.AreEqual(1, Leetcode243.ShortestDistance(words1, word21, word22));
        }
    }
}