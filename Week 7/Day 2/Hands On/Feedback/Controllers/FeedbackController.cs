using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    [Route("feedback")]
    public class FeedbackController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult Index(string name, string comments, int rating)
        {
            if (rating >= 4)
                ViewData["Message"] = "Thank You";
            else
                ViewData["Message"] = "We will improve";

            return View();
        }
    }
}