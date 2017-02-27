using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp1.Test;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLeetcode242()
        {
            Assert.AreEqual(true, Leetcode242.IsAnagram("ddf12345", "54321fdd"));
            Assert.AreEqual(false, Leetcode242.IsAnagram("d2345", "54321fdd"));

            Assert.AreEqual(true, Leetcode242.IsAnagram("春天", "天春"));
            Assert.AreEqual(false, Leetcode242.IsAnagram("春天", "春"));

            Assert.AreEqual(true, Leetcode242.IsAnagram(" 春天 123 ", "123 天春"));
            Assert.AreEqual(false, Leetcode242.IsAnagram("春 天", "春"));
        }
        [TestMethod]
        public void TestLeetcode412()
        {
            List<string> expectedList = new List<string>()
            {
            "1",
            "2",
            "Fizz",
            "4",
            "Buzz",
            "Fizz",
            "7",
            "8",
            "Fizz",
            "Buzz",
            "11",
            "Fizz",
            "13",
            "14",
            "FizzBuzz"
            };
            Assert.IsTrue(expectedList.SequenceEqual(Leetcode412.FizzBuzz(15)));
        }
        [TestMethod]
        public void TestLeetcode344()
        {
            Assert.AreEqual("321", Leetcode344.Reverse("123"));
            Assert.AreEqual("天春", Leetcode344.Reverse("春天"));
        }
        [TestMethod]
        public void TestLeetcode339()
        {
            List<object> t1 = new List<object>
            {
                1,
                1,
                new List<object>
                {
                    1,
                    1,
                    new List<object>
                    {
                        1,
                        1
                    }
                }
            };
            List<object> t2 = new List<object>
            {
                10,
                10,
                new List<object>
                {
                    100,
                    100,
                    new List<object>
                    {
                        1000,
                        1
                    }
                },
                20
            };

            Assert.AreEqual(12, Leetcode339.DepthSum(t1));
            Assert.AreEqual(3443, Leetcode339.DepthSum(t2));
        }
        [TestMethod]
        public void TestLeetcode463()
        {
            int[,] rect = new int[,]
            {
                { 0,1,0,0},
                {1,1,1,0 },
                {0,1,0,0 },
                { 1,1,0,0}
            };
            int[,] rect2 = new int[,]
            {
                { 0,1,1},
                {0,1,1 },
                {0,0,0 }
            };
            Assert.AreEqual(16, Leetcode463.IslandPerimeter(rect));
            Assert.AreEqual(8, Leetcode463.IslandPerimeter(rect2));

        }
        [TestMethod]
        public void TestLeetcode346()
        {
            Leetcode346 l346 = new Leetcode346(3);

            Assert.AreEqual(1d, l346.Next(1));
            Assert.AreEqual((double)(1+10)/2, l346.Next(10));
            Assert.AreEqual((double)(1+10+3)/3, l346.Next(3));
            Assert.AreEqual((double)(10+3+5)/3, l346.Next(5));
        }
        [TestMethod]
        public void TestLeetcode266()
        {
            Assert.AreEqual(false, Leetcode266.IsPalindrome("code"));
            Assert.AreEqual(true, Leetcode266.IsPalindrome("aab"));
            Assert.AreEqual(true, Leetcode266.IsPalindrome("carerac"));
        }
        
    }
}
