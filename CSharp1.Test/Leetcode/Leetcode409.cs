using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode409
    {
        public static int LongestPalindrome(string s)
        {
            HashSet<char> tempSet = new HashSet<char>();

            for(int i=0;i<s.Length;i++)
            {
                if(tempSet.Contains(s[i]))
                {
                    tempSet.Remove(s[i]);
                }else
                {
                    tempSet.Add(s[i]);
                }
            }

            if (tempSet.Count == 0)
            { return s.Length; }
            else
            { return s.Length - tempSet.Count + 1; }
            
        }
    }
}
