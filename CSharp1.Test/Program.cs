using CSharp1.Test.Codility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test_Delegate();
            //Test_Event();
            //Lambda();
            //EnumerableTest.Test();
            //if( Leetcode242.IsAnagram("ddf12345", "54321fdd"))
            //{
            //    Console.WriteLine("TRUE");
            //}

            // Console.WriteLine(10 | 2);
            //Leetcode371.Sum(1, 3);

            //Console.WriteLine($"a:{Convert.ToString('a', 2)}");
            //Console.WriteLine($"b:{Convert.ToString('b', 2)}");
            //Console.WriteLine($"c:{Convert.ToString('c', 2)}");
            //Console.WriteLine($"e:{Convert.ToString('e', 2)}");

            //Leetcode389.FindTheDifference("abc", "abce");

            //Console.WriteLine(Math.Pow(676,1/26m));

            //Console.WriteLine($"a:{Convert.ToString(-1, 2)}");
            //Console.WriteLine($"a:{Convert.ToString(1, 2)}");
            //Console.WriteLine($"a:{Convert.ToString(~1, 2)}");
            //Console.WriteLine($"a:{Convert.ToString(10, 16)}");

            //Console.WriteLine($"a:{Convert.ToString(3, 2)}");
            //Console.WriteLine($"a:{Convert.ToString(9, 2)}");
            //Console.WriteLine($"a:{Convert.ToString(27, 2)}");


            //CommandMain.test();
            //FacadeTest.Test();
            //AdapterTest.Test();
            //DecoratorTest.Test();
            Console.WriteLine( BinaryGap.MaxGap(9));
            Console.WriteLine( BinaryGap.MaxGap(529));
            Console.WriteLine( BinaryGap.MaxGap(20));
            Console.WriteLine( BinaryGap.MaxGap(15));
            Console.WriteLine( BinaryGap.MaxGap(1041));
            Console.ReadLine();
        }

        public static void Lambda()
        {
            LambdaTest l = new LambdaTest();
            l.Test();
        }

        public static void Test_Event()
        {
            EventSender_Clock ec = new EventSender_Clock();
            ec.Click += Onclick1;
            ec.Click += Onclick2;
            ec.OnClick(new EventArgs());
           
        }
        public static void Onclick1(object sender, EventArgs e )
        {
            Console.WriteLine($"OnClick1");
        }
        public static void Onclick2(object sender, EventArgs e)
        {
            Console.WriteLine($"OnClick2");
        }

        public static void Test_Delegate()
        {
            delPrint d = new delPrint(Print1);
            d("hello");
        }
        delegate void delPrint(string input);
        public static void Print1(string str)
        {
            Console.WriteLine($"Print1: {str}");
        }
    }
}
