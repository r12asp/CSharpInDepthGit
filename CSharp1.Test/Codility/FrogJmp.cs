using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test.Codility
{
    public class FrogJmp
    {
        public static int Jmp(int x,int y,int d)
        {
            if((y-x)%d ==0)
            {
                return (y - x) / d;
            }else
            {
                return ((y - x) / d) +1;
            }
        }
    }
}
