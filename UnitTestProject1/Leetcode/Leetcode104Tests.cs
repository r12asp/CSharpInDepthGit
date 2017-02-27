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
    public class Leetcode104Tests
    {
        [TestMethod()]
        public void MaxDepthTest()
        {
            TreeNode n1 = new TreeNode(1) {
                left = new TreeNode(2) {
                    left = new TreeNode(3)
                    {
                        left = new TreeNode(4)
                    }
                },
                right = new TreeNode(5)
            };

            Assert.AreEqual(4, Leetcode104.MaxDepth(n1));
        }
    }
}