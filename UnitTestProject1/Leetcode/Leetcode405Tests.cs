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
    public class Leetcode405Tests
    {
        [TestMethod()]
        public void ConvertToHexadecimalTest()
        {
            Assert.AreEqual("1a", Leetcode405.ConvertToHexadecimal(26));
        }
    }
}