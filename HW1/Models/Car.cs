namespace HW1.Models
{
    public class Car
    {
        private string carBrand;
        private string carType;
        private string carColor; 
        private int productionYear;
        
        public string CarBrand { get { return carBrand; } set { carBrand = value; } }
        public string CarType { get { return carType; } set { carType = value; } }
        public string CarColor { get { return carColor; } set { carColor = value; } }
        public int ProductionYear { get {  return productionYear; } set {  productionYear = value; } }

        public Car() { }


    }
}
