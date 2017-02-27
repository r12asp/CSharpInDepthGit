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
    public class OddOccurrencesInArrayTests_Pattern_Singleton
    {
        [TestMethod()]
        public void OddUnpairedTest()
        {
            int[] t1 = new int[] { 9, 3, 9, 3, 9, 7, 9 };
            Assert.AreEqual(7, OddOccurrencesInArray.OddUnpaired(t1));
        }
    }
}