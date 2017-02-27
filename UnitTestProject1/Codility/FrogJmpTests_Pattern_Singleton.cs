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
    public class FrogJmpTests_Pattern_Singleton
    {
        [TestMethod()]
        public void JmpTest()
        {
            Assert.AreEqual(3, FrogJmp.Jmp(10, 75, 30));
            Assert.AreEqual(3, FrogJmp.Jmp(3, 8, 2));
            Assert.AreEqual(4, FrogJmp.Jmp(101, 300, 50));
        }
    }
}