using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public struct StructBase
    {
        public int ID;

        public int GetID()
        {
            return ID;
        }
    }

    public struct StructChild 
    {
        public DateTime d;
    }
}
