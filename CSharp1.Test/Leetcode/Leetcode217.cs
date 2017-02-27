using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode217
    {
        public static Boolean ContainsDuplicate(int[] nums)
        {
            HashSet<int> tempSet = new HashSet<int>();

            for(int i =0;i<nums.Length;i++)
            {
                if(tempSet.Contains(nums[i]))
                {
                    tempSet.Remove(nums[i]);
                }else
                {
                    tempSet.Add(nums[i]);
                }
            }
            return tempSet.Count != nums.Length;
        }
    }
}
