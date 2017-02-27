using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode339
    {
        public static int DepthSum(List<object> list)
        {
            return Help(list, 0);
        }
        public static int Help(List<object> list, int level)
        {
            int sum = 0;
            level++;
            foreach (object iObject in list)
            {
                if (iObject is int)
                {
                    sum += (int)iObject * level;
                }
                if (iObject is List<object>)
                {
                    sum += Help((List<object>)iObject, level);
                }
            }
            return sum;
        }
    }
}
