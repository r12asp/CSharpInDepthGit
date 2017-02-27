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
    public class Leetcode404Tests
    {
        [TestMethod()]
        public void SumOfLeftTest()
        {
            TreeNode t1 = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
                {
                    left = new TreeNode(15),
                    right = new TreeNode(7)
                }
            };
            TreeNode t2 = new TreeNode(5)
            {
                left = new TreeNode(1)
                {
                    left = new TreeNode(7),
                    right = new TreeNode(8)
                    {
                        left = new TreeNode(6)
                    }
                },
                right = new TreeNode(2)
            };

            Assert.AreEqual(24, Leetcode404.SumOfLeft(t1));
            Assert.AreEqual(14, Leetcode404.SumOfLeft(t2));
        }
    }
}