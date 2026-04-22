using Microsoft.AspNetCore.Mvc;
using WebApplication8._2.Repositories;

namespace WebApplication8._2.Controllers;

public class StudentController : Controller
{
    private readonly IStudentRepository _repo;

    public StudentController(IStudentRepository repo)
    {
        _repo = repo;
    }

    public IActionResult Index()
    {
        return View(_repo.GetStudentsWithCourse());
    }

    public IActionResult Courses()
    {
        return View(_repo.GetCoursesWithStudents());
    }
}