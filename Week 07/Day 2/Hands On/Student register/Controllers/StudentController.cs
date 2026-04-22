using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("student")]
    public class StudentController : Controller
    {
        [HttpGet("regsiter")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(string name, int age, string course)
        {
            ViewBag.Name = name;
            ViewBag.Age = age;
            ViewBag.Course = course;

            return RedirectToAction("Display");
        }

        [HttpGet("display")]
        public IActionResult Display()
        {
            return View();
        }
    }
}
