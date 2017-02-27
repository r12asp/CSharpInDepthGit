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
    public class PermMissingElemTests_Pattern_Singleton
    {
        [TestMethod()]
        public void MissingTest()
        {
            int[] t1 = new int[] { 2, 3, 1, 5 };
            int[] t2 = new int[] { 2, 3, 1, 5,4,6,8 };
            int[] t3 = new int[] { 2, 3, 1, 5,4,6,8,7,9,10,12 };
            Assert.AreEqual(4, PermMissingElem.Missing(t1));
            Assert.AreEqual(7, PermMissingElem.Missing(t2));
            Assert.AreEqual(11, PermMissingElem.Missing(t3));
        }
    }
}