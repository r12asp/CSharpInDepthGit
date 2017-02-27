using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    class CarModel
    {
        public void SetModel()
        {
            Console.WriteLine("CarModel.SetModel");
        }
    }
    class CarEngine
    {
        public void SetEngine()
        {
            Console.WriteLine("CarEngine.SetEngine");
        }
    }
    class CarBody
    {
        public void SetBody()
        {
            Console.WriteLine("Carbody.Setbody");
        }
    }

    public class CarFacade
    {
        private readonly CarBody _carBody = new CarBody();
        private readonly CarEngine _carEngine = new CarEngine();
        private readonly CarModel _carModel = new CarModel();

        public CarFacade()
        {
            _carBody = new CarBody();
            _carEngine = new CarEngine();
            _carModel = new CarModel();
        }

        public void CreateCompleteCar()
        {
            _carModel.SetModel();
            _carEngine.SetEngine();
            _carBody.SetBody();
        }
    }
    public class FacadeTest
    {
        public static void Test()
        {
            CarFacade c = new CarFacade();
            c.CreateCompleteCar();
        }
    }
}
