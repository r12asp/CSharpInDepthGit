using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode326
    {
        public static Boolean PowerOfTree(int num)
        {
            return (num > 0 && 1162261467 % num == 0);
        }
    }
}
