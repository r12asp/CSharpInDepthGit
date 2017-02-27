using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode171
    {
        public static int ExcelSheetColumnNumber(string title)
        {
            title = title.ToLower();
            int sum = 0;
            for(int i = 0;i<title.Length;i++)
            {
                sum += (title[i] - 'a' + 1) * (int)Math.Pow(26, title.Length - i-1);
            }
            return sum;
        }
    }
}
