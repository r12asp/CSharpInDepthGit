using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode344
    {
        public static string Reverse(string str)
        {
            List<char> reversed = new List<char>();
            Stack<char> sl = new Stack<char>();
            foreach(char c in str.ToList<char>())
            {
                sl.Push(c);
            }
            while(sl.Count>0)
            {
                reversed.Add(sl.Pop());
            }
            return new string(reversed.ToArray());
        }
    }
}
