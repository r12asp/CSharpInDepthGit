using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode226
    {
        public static TreeNode InvertTree(TreeNode root)
        {
            if (root.left == null && root.right == null) return root;

            if(root.left!=null && root.right != null)
            {
                TreeNode temp = root.right;
                root.right = root.left;
                root.left = temp;
                InvertTree(root.left);
                InvertTree(root.right);
            }
            if (root.left != null && root.right == null)
            {
                root.right = root.left;
                root.left = null;
                InvertTree(root.right);
            }
            if( root.left == null && root.right != null)
            {
                root.left = root.right;
                root.right = null;
                InvertTree(root.left);
            }

            return root;
        }
    }
}
