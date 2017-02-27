using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode459
    {
        public static Boolean RepeatedSubstring(string str)
        {
            int strLength = str.Length;

            for(int i=strLength/2;i>=1;i--)
            {
                if(strLength%i==0)
                {
                    int m = strLength / i;
                    string subStr = str.Substring(0, i);
                    StringBuilder sb = new StringBuilder();
                    for(int j=0;j<m;j++)
                    {
                        sb.Append(subStr);
                    }
                    if (sb.ToString().Equals(str)) return true;
                }
            }
            return false;
        }
    }
}
