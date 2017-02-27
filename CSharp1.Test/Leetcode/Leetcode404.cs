using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode404
    {
        public static int SumOfLeft(TreeNode root)
        {
            if(root.left != null && root.right == null )
            {
                return root.left.val + SumOfLeft(root.left);
            }else if(root.left != null && root.right != null )
            {
                return root.left.val + SumOfLeft(root.left) + SumOfLeft(root.right);
            }else if(root.left == null && root.right != null)
            {
                return SumOfLeft(root.right);
            }else
            {
                return 0;
            }
        }
    }
}
