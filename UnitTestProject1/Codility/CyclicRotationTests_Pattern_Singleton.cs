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
    public class CyclicRotationTests_Pattern_Singleton
    {
        [TestMethod()]
        public void RotateTest()
        {
            int[] t1 = new int[] { 3, 8, 9, 7, 6 };
            int[] t11 = new int[] {6, 3, 8, 9, 7};
            int[] t13 = new int[] { 9, 7,6, 3, 8};

            CollectionAssert.AreEquivalent(t11, CyclicRotation.Rotate(t1, 1));
            CollectionAssert.AreEquivalent(t13, CyclicRotation.Rotate(t1, 3));
        }
    }
}