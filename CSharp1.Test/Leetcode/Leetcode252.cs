using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode252
    {
        public static Boolean MeetingRooms(Interval[] intervals)
        {
            Array.Sort(intervals, (a, b) => (a.start - b.start));

            for( int i =0;i< intervals.Length-1;i++)
            {
                if (intervals[i + 1].start < intervals[i].end) return false;
            }

            return true;
        }
        
    }
}
