using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode401
    {
        public static string[] BinaryWatch(int n)
        {
            List<String> times = new List<string>();
            for(int h=0;h<12;h++)
            {
                for(int m =0;m<60;m++)
                {
                    if(SparseBitcount(h*64+m)==n)
                    {
                        times.Add(String.Format("{0:0}:{1:00}", h, m));
                    }
                }
            }
            return times.ToArray<string>();
        }

        static int SparseBitcount(int n)
        {
            int count = 0;
            while (n != 0)
            {
                count++;
                n &= (n - 1);
            }
            return count;
        }
    }
}
