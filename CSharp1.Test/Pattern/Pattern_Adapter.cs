using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    class Adaptee
    {
        public double SpecificRequest(double a, double b)
        {
            return a / b;
        }        
    }
    interface ITarget
    {
        string Request(int i);
    }

    class Adapter: Adaptee, ITarget
    {
        public string Request(int i)
        {
            return "Round estimate is" + (int)Math.Round(SpecificRequest(i, 3));
        }
    }
    public class AdapterTest
    {
        public static void Test()
        {
            Adaptee a = new Adaptee();
            Console.WriteLine(a.SpecificRequest(5,3));

            ITarget t = new Adapter();
            Console.WriteLine( t.Request(5));
        }
    }
}
