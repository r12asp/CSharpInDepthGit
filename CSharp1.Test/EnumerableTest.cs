using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    class EnumerableTest
    {
        public static void Test()
        {
            //var collection = Enumerable.Range(0, 10)
            //    .Where(t=>t%2==0)
            //    .Reverse()
            //    .Select(t=>new { Original =t,SquareRoot=Math.Sqrt(t)})
            //    .OrderBy(x=>x.SquareRoot)
            //    .ThenBy(x=>x.Original);

            List<string> list= new List<string>()
            {
                "dog","pig","cock"
            };

            var collection = from entry in list
                             select entry;

            foreach(var element in collection)
            {
                //Console.WriteLine($"Original:{element.Original} SquareRoot:{element.SquareRoot}");
                Console.WriteLine(element);
            }
        }

    }
}
