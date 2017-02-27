using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp1.Test.Codility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test.Codility.Tests
{
    [TestClass()]
    public class BinaryGapTests_Pattern_Singleton
    {
        [TestMethod()]
        public void MaxGapTest()
        {
            Assert.AreEqual(BinaryGap.MaxGap(9), 2);
            Assert.AreEqual(BinaryGap.MaxGap(529), 4);
            Assert.AreEqual(BinaryGap.MaxGap(20), 1);
            Assert.AreEqual(BinaryGap.MaxGap(15), 0);
            Assert.AreEqual(BinaryGap.MaxGap(1041), 5);
        }
    }
}