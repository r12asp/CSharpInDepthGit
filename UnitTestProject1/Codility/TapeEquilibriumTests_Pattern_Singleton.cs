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
    public class TapeEquilibriumTests_Pattern_Singleton
    {
        [TestMethod()]
        public void MinTest()
        {
            int[] t1 = new int[] {3,1,2,4,3 };
            int[] t2 = new int[] {30,19,2,8,33 };

            Assert.AreEqual(1, TapeEquilibrium.Min(t1));
            Assert.AreEqual(6, TapeEquilibrium.Min(t2));
        }
    }
}