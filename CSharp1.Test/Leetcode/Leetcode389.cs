using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode389
    {
        public static char FindTheDifference(string s,string t)
        {
            char c = (char)0;
            for (int i=0;i<s.Length;i++)
            {
                //Console.WriteLine($"s[i]:{Convert.ToString(s[i], 2)}");
                //Console.WriteLine($"c before:{Convert.ToString(c, 2)}");
                c ^= s[i];
                //Console.WriteLine($"c after:{Convert.ToString(c, 2)}");
            }
            //Console.WriteLine(new string('+',20));
            for (int i=0;i<t.Length;i++)
            {
                //Console.WriteLine($"t[i]:{Convert.ToString(t[i], 2)}");
                //Console.WriteLine($"c before:{Convert.ToString(c, 2)}");
                c ^= t[i];
                //Console.WriteLine($"c after:{Convert.ToString(c, 2)}");
            }
            return c;
        }
    }
}
