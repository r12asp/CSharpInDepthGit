using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode350
    {
        public static int[] IntersectionOfTwoArraysII(int[] nums1, int[] nums2)
        {
            List<int> intersection = new List<int>();

            foreach (int i in nums1)
            {
                if (nums2.Contains(i))
                {
                    intersection.Add(i);
                }
            }
            return intersection.ToArray<int>();
        }
    }
}
