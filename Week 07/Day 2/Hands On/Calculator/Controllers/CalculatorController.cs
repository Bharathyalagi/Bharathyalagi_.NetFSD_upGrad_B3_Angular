using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    [Route("calc")]
    public class CalculatorController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult Index(int num1, int num2)
        {
            ViewData["Result"] = num1 + num2;
            return View();
        }
    }
}