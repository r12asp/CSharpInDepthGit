using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode405
    {
        public static string ConvertToHexadecimal(int num)
        {
            char[] map = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };

            if (num == 0) return "0";
            string result = "";
            while(num !=0)
            {
                result = map[(num & 15)] + result;
                num = (num >> 4);
            }
            return result;
        }
    }
}
