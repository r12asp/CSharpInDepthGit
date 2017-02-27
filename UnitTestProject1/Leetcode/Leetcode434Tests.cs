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
    public class Leetcode434Tests
    {
        [TestMethod()]
        public void NumberOfSegmentsInStringTest()
        {
            Assert.AreEqual(5, Leetcode434.NumberOfSegmentsInString("Hello, my name is John"));
        }
    }
}