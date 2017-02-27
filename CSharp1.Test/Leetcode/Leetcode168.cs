using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode168
    {
        public static string ExcelSheetColumnTitle(int num)
        {
            return num == 0 ? "" : ExcelSheetColumnTitle((num - 1) / 26) + (char)((num - 1) % 26 + 'A');
        }
    }
}
