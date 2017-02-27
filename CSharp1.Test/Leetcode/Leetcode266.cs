using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode266
    {
        public static Boolean IsPalindrome(string str)
        {
            HashSet<char> tempSet = new HashSet<char>();

            foreach (char iChar in str.ToCharArray())
            {
                if (tempSet.Contains(iChar))
                {
                    tempSet.Remove(iChar);
                }
                else
                {
                    tempSet.Add(iChar);
                }
            }

            if( tempSet.Count ==0 ||tempSet.Count == 1)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
