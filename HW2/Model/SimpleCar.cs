using HW2.Interface;

namespace HW2.Model
{
    public class SimpleCar : IManagementCars
    {
        readonly string _carName;
        readonly int _carEngine;
        readonly int _carAge;
        
        public SimpleCar() { }
        public SimpleCar(string carName, int carEngine, int carAge)
        {
            _carName = carName;
            _carEngine = carEngine;
            _carAge = carAge;
        }
        

        public int GetCarAge()
        {
           return _carAge;
        }

        public int GetCarEngine()
        {
            return _carEngine;
        }

        public string GetCarName()
        {
            return _carName;
        }
    }
}
