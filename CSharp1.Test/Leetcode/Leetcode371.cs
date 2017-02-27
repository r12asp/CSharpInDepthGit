using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode371
    {
        public static int Sum(int a, int b)
        {
            if (a == 0) return b;
            if (b == 0) return a;

            while (b != 0)
            {
                int carry = a & b;
                a = a ^ b;
                b = carry << 1;

                Console.WriteLine($"carry:{carry}:{Convert.ToString(carry,2)}");
                Console.WriteLine($"a:{a}:{Convert.ToString(a,2)}");
                Console.WriteLine($"b:{b}:{Convert.ToString(b,2)}");

                Console.WriteLine( new string( '=', 20));
                //Console.WriteLine($"{Convert.ToString(15,2)}");
            }

            return a;
        }
    }
}
