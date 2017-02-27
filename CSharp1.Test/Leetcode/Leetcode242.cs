using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode242
    {
        public static bool IsAnagram(string s, string t)
        {
            List<char> sl = s.Trim().ToList<char>();
            sl.Sort();
            List<char> tl = t.Trim().ToList<char>();
            tl.Sort();
            string s2 = new string( sl.ToArray());
            string t2 = new string( tl.ToArray());
            //Console.WriteLine($"s:{s2}");
            //Console.WriteLine($"s:{t2}");
            if (s2 == t2)
            {
                return true;
            }
            return false;
                
        }
    }
}
