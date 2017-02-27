using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode434
    {
        public static int NumberOfSegmentsInString(string str)
        {
            int res = 0;
            for(int i=0;i<str.Length;i++)
            {
                if(str[i] !=' ' && (i==0 || str[i-1] == ' '))
                {
                    res++;
                }
            }
            return res;
        }
    }
}
