using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode169
    {
        public static int MajorityElement(int[] nums)
        {
            Array.Sort(nums);
            return nums[(nums.Length + 1) / 2];
        }
    }
}
