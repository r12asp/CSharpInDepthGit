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
    public class Leetcode252Tests
    {
        [TestMethod()]
        public void MeetingRoomsTest()
        {
            Interval[] intervals1 = new Interval[]
            {
                new Interval(0,30),
                new Interval(5,10),
                new Interval(15,20)
            };
            Interval[] intervals2 = new Interval[]
            {
                            new Interval(0,30),
                            new Interval(30,40),
                            new Interval(40,80)
            };

            Assert.IsFalse(Leetcode252.MeetingRooms(intervals1));
            Assert.IsTrue(Leetcode252.MeetingRooms(intervals2));
        }
    }
}