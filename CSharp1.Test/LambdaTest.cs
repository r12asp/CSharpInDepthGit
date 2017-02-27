using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class LambdaTestEntity
    {
        public int ID { set; get; }
        public string Name { set; get; }
    }
    public class LambdaTest
    {
        public void Test()
        {
            var list = new List<LambdaTestEntity>
            {
                new LambdaTestEntity { ID=1,Name="Brisbane"},
                new LambdaTestEntity {ID=2,Name="Sydney" },
                new LambdaTestEntity {ID=3,Name="Adelaide" },
                new LambdaTestEntity {ID=4,Name="Perth" },
                new LambdaTestEntity {ID=5,Name="Melborne" },
            };

            Action<LambdaTestEntity> listPrint = L => Console.WriteLine($"Name:{L.Name} ID:{L.ID}");
            list.ForEach(listPrint);
            Console.WriteLine();

            list.FindAll(L => L.ID < 3).ForEach(listPrint);
            Console.WriteLine();

            list.Sort((L1, L2) => L1.Name.CompareTo(L2.Name));
            list.ForEach(listPrint);
       }
    }

}
