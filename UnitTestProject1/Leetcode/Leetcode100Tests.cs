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
    public class Leetcode100Tests
    {
        [TestMethod()]
        public void IsSameTreeTest()
        {
            TreeNode n1 = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(3)
                    {
                        left = new TreeNode(4)
                    }
                },
                right = new TreeNode(5)
            };

            TreeNode n2 = new TreeNode(9)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(6)
                    {
                        left = new TreeNode(4),
                        right = new TreeNode(11)
                    }
                },
                right = new TreeNode(5)
            };

            Assert.IsTrue(Leetcode100.IsSameTree(n1, n1));
            Assert.IsFalse(Leetcode100.IsSameTree(n1, n2));
        }
    }
}