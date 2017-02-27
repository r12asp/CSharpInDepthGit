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
    public class Pattern_SingletonTests
    {
        [TestMethod()]
        public void Pattern_SingletonTest()
        {
            Pattern_Singleton xx = Pattern_Singleton.Instance;
            Pattern_Singleton xx2 = Pattern_Singleton.Instance;
            Assert.ReferenceEquals(xx, xx2);
        }
    }
}