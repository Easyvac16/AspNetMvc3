using AspNetMvc3.Abstractions;
using AspNetMvc3.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc3.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarsOutputService _carsOutputService;
        public CarController(ICarsOutputService carsOutputService)
        {
            _carsOutputService = carsOutputService;
        }
        public IActionResult CarsView()
        {
            return View("CarsView", new CarViewModel());
        }

        public IActionResult CarsList()
        {
            var carList = _carsOutputService.LoadFromFile("cars.txt");

            return View("CarsList", carList);
        }
        [HttpPost]
        public IActionResult CreateCar(CarViewModel model)
        {
            var result = _carsOutputService.CreateCar(model);
            return View("CarsView", model);
        }
    }
}
