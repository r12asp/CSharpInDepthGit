using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode453
    {
        public static int MinMoves(int[] nums)
        {
            int min = int.MaxValue;
            int sum = 0;
            Array.ForEach(nums, delegate (int x) {
                min = Math.Min(x, min);
                sum += x;
            });
            return sum - min * nums.Length;
        }
    }
}
