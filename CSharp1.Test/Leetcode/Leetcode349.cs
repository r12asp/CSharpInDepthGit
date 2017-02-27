using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode349
    {
        public static int[] IntersectionOfTwoArrays(int[] nums1, int[] nums2)
        {
            List<int> intersection = new List<int>();

            foreach(int i in nums2)
            {
                if (nums1.Contains(i) && !intersection.Contains(i))
                {
                    intersection.Add(i);
                }
            }

            return intersection.ToArray<int>();
        }
    }
}
