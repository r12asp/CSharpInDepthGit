using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test.Codility
{
    public class PermMissingElem
    {
        public static int Missing(int[] a)
        {
            int missInt = 0;
            for(int i=1;i<=a.Length;i++)
            {
                missInt = i ^ a[i-1];
            }
            return missInt ^ a.Length+1;
        }
    }
}
