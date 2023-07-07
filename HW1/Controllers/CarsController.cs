using HW1.Models;
using Microsoft.AspNetCore.Mvc;

namespace HW1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : Controller
    {
        public CarsController() { }

        private static readonly string[] Colors = new[]
        {
        "Red","Grey","Light blue","Dark blue","Green","Yellow","Pink","Orange","Brown","White","Black","Violet" 
        };

        private static readonly string[] CarType = new[]
        {
        "Sedan","Hatchback","Universal","Coupe","Van","Pickup"
        };
        private static readonly string[] CarBrand = new[]
        {
        "VW","Honda","Zaz","Renault","Citroen","Fiat"
        };

        [HttpGet(Name = "GetCars")]
        public IEnumerable<Car> GetCars()
        {
            return Enumerable.Range(1, 5).Select(car => new Car
            {
                CarBrand = CarBrand[Random.Shared.Next(CarBrand.Length)],
                CarType = CarType[Random.Shared.Next(CarType.Length)],
                CarColor = Colors[Random.Shared.Next(Colors.Length)],
                ProductionYear = Random.Shared.Next(1950, 2023)
            }
            ).ToArray();

        }
    
    }
}
