using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test.Codility
{
    public class CyclicRotation
    {
        public static int[] Rotate(int[] a,int k)
        {
            for(int i =0;i<k;i++)
            {
                int tempLast = a[a.Length - 1];

                int tempPrevious = 0;
                for (int j=0;j<a.Length-1 ;j++)
                {

                        int xx = a[j + 1];
                        a[j + 1] = j==0?a[0]: tempPrevious;
                        tempPrevious = xx;
                    
                }
                a[0] = tempLast;
            }
            return a;
        }
    }
}
