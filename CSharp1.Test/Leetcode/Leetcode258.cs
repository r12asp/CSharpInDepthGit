using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode258
    {
        public static int OneDigit(int num)
        {
            return num == 0 ? 0 : (num % 9 == 0 ? 9 : (num % 9));
        }
    }
}
