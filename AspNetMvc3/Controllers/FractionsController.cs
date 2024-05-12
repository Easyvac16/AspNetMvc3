using AspNetMvc3.Abstractions;
using AspNetMvc3.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc3.Controllers
{
    public class FractionsController : Controller
    {
        private readonly IFractionservice _fractionService;

        public FractionsController(IFractionservice fractionService)
        {
            _fractionService = fractionService;
        }

        public IActionResult FractionsView()
        {
            return View("FractionsView", new FractionsOperationViewModel());
        }

        [HttpPost]
        public IActionResult Calculate(FractionsOperationViewModel model)
        {
            var result = _fractionService.Calculate(model);
            return View("FractionsView", model);
        }
    }
}
