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
    public class Leetcode168Tests
    {
        [TestMethod()]
        public void ExcelSheetColumnTitleTest()
        {
            Assert.AreEqual("A",Leetcode168.ExcelSheetColumnTitle(1));
            Assert.AreEqual("Z",Leetcode168.ExcelSheetColumnTitle(26));
            Assert.AreEqual("AA",Leetcode168.ExcelSheetColumnTitle(27));
            Assert.AreEqual("AB",Leetcode168.ExcelSheetColumnTitle(28));

        }
    }
}