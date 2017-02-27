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
    public class Leetcode226Tests
    {
        [TestMethod()]
        public void InvertTreeTest()
        {
            TreeNode n1 = new TreeNode(4)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(1),
                    right = new TreeNode(3)
                },
                right = new TreeNode(7)
                {
                    left = new TreeNode(6),
                    right = new TreeNode(9)
                }
            };

            TreeNode n2 = new TreeNode(4)
            {
                left = new TreeNode(7)
                {
                    left = new TreeNode(9),
                    right = new TreeNode(6)
                },
                right = new TreeNode(2)
                {
                    left = new TreeNode(3),
                    right = new TreeNode(1)
                }
            };

            TreeNode inverted = Leetcode226.InvertTree(n1);

            List<int> expectedList = new List<int>();
            n2.GetAllList(n2, expectedList);

            List<int> invertedList = new List<int>();
            inverted.GetAllList(inverted, invertedList);

            expectedList.ForEach(delegate (int i) { Console.Write(i); });
            Console.WriteLine();
            expectedList.ForEach(delegate (int i) { Console.Write(i); });


            Assert.IsTrue(expectedList.SequenceEqual(invertedList));
        }
    }
}