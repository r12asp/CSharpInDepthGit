using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode100
    {
        public static bool IsSameTree( TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null) return true;
            if (t1 == null || t2 == null) return false;
            if(t1.val == t2.val )
            {
                return IsSameTree(t1.left, t2.left) && IsSameTree(t1.right, t2.right);
            }else
            {
                return false;
            }
        }
    }
}
