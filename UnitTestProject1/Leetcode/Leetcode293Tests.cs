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
    public class Leetcode293Tests
    {
        [TestMethod()]
        public void IsPalindromeTest()
        {
            string inputStr = "++++";

            List<string> expectedList = new List<string>()
            {
                 "--++",
                  "+--+",
                  "++--"
            };

            Assert.IsTrue(expectedList.SequenceEqual(Leetcode293.AllStates(inputStr)));
        }
    }
}