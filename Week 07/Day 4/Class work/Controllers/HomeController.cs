using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Emps()
    {
        var emps = _context.Employees.Include(e => e.Dept).ToList();
        return View(emps);
    }

    public IActionResult Depts()
    {
        var depts = _context.Depts.Include(d => d.Employees).ToList();
        return View(depts);
    }
}