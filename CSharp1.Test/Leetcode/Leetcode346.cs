using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode346
    {
        ArrayList list = new ArrayList();
        int windowSize = 0;
        public Leetcode346(int size)
        {
            windowSize = size;
        }
        public double Next(int newNumber)
        {
            list.Add(newNumber);
            double temp=0;

            if (windowSize > list.Count) return (double)((int[])list.ToArray(typeof(int))).Sum()/list.Count;

            for( int i = list.Count-1 ; i >= (list.Count - windowSize ) ; i--)
            {
                temp += (int)list[i];
            }
            
            return temp/ (double)windowSize;
        }
    }
}
