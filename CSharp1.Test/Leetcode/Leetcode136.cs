using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode136
    {
        public static int SingleNumber(int[] nums)
        {
            HashSet<int> temp = new HashSet<int>();
            for(int i =0;i<nums.Length;i++ )
            {
                if(temp.Contains(nums[i]))
                {
                    temp.Remove(nums[i]);
                }else
                {
                    temp.Add(nums[i]);
                }
            }
            return temp.First<int>();
        }
    }
}
