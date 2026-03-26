using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Net.NetworkInformation;
using System.Reflection;

namespace MVC.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            var list = new List<Employee>()
            {
                new Employee { Empno = 101, Ename = "Bharath", Job = "Dev", Salary = 50000, Deptno = 10 },
                new Employee { Empno = 102, Ename = "Bhuvan", Job = "Tester", Salary = 40000, Deptno = 20 },
                new Employee { Empno = 102, Ename = "Sushmita", Job = "Automation", Salary = 40000, Deptno = 20 }
            };

            return View(list);
        }
    }
}



