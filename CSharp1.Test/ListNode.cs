using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class ListNode
    {
        public int val;
        public ListNode Next;
        public ListNode(int x) { val = x; }

        public IList<int> AllList()
        {
            List<int> list = new List<int>();
            GetAllList(this, list);
            return list;
        }
        public void GetAllList( ListNode node, List<int> allList )
        {
            if (node.Next != null)
            {
                allList.Add(node.Next.val);
                GetAllList(node.Next, allList);
            }else
            { return; }
            
        }
    }
}
