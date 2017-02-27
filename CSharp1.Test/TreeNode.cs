using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }

        List<int> all = new List<int>();
        public void GetAllList( TreeNode node, List<int> all)
        {
            all.Add(node.val);
            if (node.left != null) GetAllList(node.left,  all);
            if (node.right != null) GetAllList(node.right,  all);
        }
    }
}
