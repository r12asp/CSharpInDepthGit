using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test.Codility
{
    public class OddOccurrencesInArray
    {
        public static int OddUnpaired(int[] a)
        {
            int temp = 0;
            foreach(int i in a)
            {
                temp ^= i;
            }
            return temp;
        }
    }
}
