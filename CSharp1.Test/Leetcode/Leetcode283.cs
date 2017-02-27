using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode283
    {
        public static void MoveZeroes(int[] arr)
        {
            if( arr == null || arr.Length ==0 ) return;

            int insertPosition = 0;
            for(int i = 0;i< arr.Length;i++)
            {
                if(arr[i] != 0 ) { arr[insertPosition++] = arr[i]; }
            }
            while(insertPosition < arr.Length)
            {
                arr[insertPosition++] = 0;
            }
        }
    }
}
