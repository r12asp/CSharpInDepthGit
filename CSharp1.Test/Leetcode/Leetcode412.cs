using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode412
    {
        public static IList<string> FizzBuzz(int n)
        {
            List<string> outList = new List<string>();
            for(int i=1; i<=n;i++)
            {
                if( i%3==0 && i%5==0 )
                {
                    outList.Add("FizzBuzz");
                }
                else if(i % 3 == 0 && i % 5 != 0)
                {
                    outList.Add("Fizz");
                }
                else if (i % 3 != 0 && i % 5 == 0)
                {
                    outList.Add("Buzz");
                }
                else
                {
                    outList.Add(i.ToString());
                }
            }
            return outList;

        }
    }
}
