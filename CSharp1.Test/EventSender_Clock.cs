using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class EventSender_Clock
    {
        public event EventHandler Click;
        public void OnClick(EventArgs e)
        {
            EventHandler handler = Click;
            if(handler!=null)
            {
                handler(this, e);
            }
        }
    }
}
