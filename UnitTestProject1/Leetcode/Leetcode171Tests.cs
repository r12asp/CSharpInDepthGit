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
    public class Leetcode171Tests
    {
        [TestMethod()]
        public void ExcelSheetColumnNumberTest()
        {
            Assert.AreEqual(3, Leetcode171.ExcelSheetColumnNumber("c"));
            Assert.AreEqual(26, Leetcode171.ExcelSheetColumnNumber("z"));
            Assert.AreEqual(27, Leetcode171.ExcelSheetColumnNumber("aa"));
            Assert.AreEqual(28, Leetcode171.ExcelSheetColumnNumber("ab"));
        }
    }
}