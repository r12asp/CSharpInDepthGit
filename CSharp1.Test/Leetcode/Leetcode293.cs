using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode293
    {
        public static List<string> AllStates(string str)
        {
            List<string> allStates = new List<string>();

            for( int i=0;i<str.Length;i++)
            {
                if(i < str.Length - 1 && str[i]=='+' && str[i+1]=='+')
                {
                    char[] temp = str.ToCharArray();
                    temp[i] = '-';
                    temp[i + 1] = '-';
                    allStates.Add( new string( temp));
                }
            }
            return allStates;
        }
    }
}
