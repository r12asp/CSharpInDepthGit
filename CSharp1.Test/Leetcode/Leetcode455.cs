using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode455
    {
        public static int ContentedNum(int[] children,int[] cookies)
        {
            Array.Sort(children);
            Array.Sort(cookies);
            int num = 0;
            for(int i=0;i<children.Length&&i<cookies.Length;i++)
            {
                if (cookies[i] >= children[i]) num++;
            }
            return num;
        }
    }
}
