using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode387
    {
        public static int FirstUniqueChar(string str)
        {
            int[] freq = new int[26];

            for(int i=0;i<str.Length;i++)
            {
                freq[str[i] - 'a']++;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (freq[str[i] - 'a'] == 1) return i;
            }
            return -1;
        }
    }
}
