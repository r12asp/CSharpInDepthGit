using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Pattern_FactoryMethod
    {
        public Car CreateACar()
        {
            return new Car();
        }
    }

    public class Car
    { }
}
