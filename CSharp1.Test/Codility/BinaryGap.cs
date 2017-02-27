using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test.Codility
{
    public class BinaryGap
    {
        public static int MaxGap(int n)
        {
            var nStr = Convert.ToString(n, 2);
            Console.WriteLine(nStr);

            int mg = 0;
            int tempIndex = -1;
            int index = 0;
            foreach(char s in nStr.ToCharArray())
            {
                if(s == '1' && tempIndex !=-1)
                {
                    mg = (index - tempIndex-1) > mg ? (index - tempIndex-1) : mg;
                    tempIndex = index;
                }else if(s=='1' && tempIndex==-1)
                {
                    tempIndex = index;
                }

                index++;
            }

            return mg;
        }
    }
}
