using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test.Codility
{
    public class TapeEquilibrium
    {
        public static int Min(int[] a)
        {
            int sum = 0;
            for(int i=0;i<a.Length;i++)
            {
                sum += a[i];
            }
            int min = int.MaxValue;
            int temp = 0;
            for(int j=0;j<a.Length-1;j++)
            {
                temp += a[j];                
                min = min > Math.Abs( sum - 2 * temp)? Math.Abs(sum - 2 * temp) : min;
            }
            return min;
        }
    }
}
