using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode243
    {
        public static int ShortestDistance(string[] words,string word1,string word2)
        {
            int index = -1, minDistance = int.MaxValue;

            for(int i=0;i<words.Length;i++)
            {
                if(words[i] == word1 || words[i] ==word2 )
                {
                    if( index != -1 && words[index] != words[i] )
                    {
                        minDistance = Math.Min(minDistance, i-index);
                    }
                    index = i;
                }
            }

            return minDistance;
        }
    }
}
