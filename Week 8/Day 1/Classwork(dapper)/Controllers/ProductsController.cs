using Microsoft.AspNetCore.Mvc;
using WebApplication24.Models;

public class ProductsController : Controller
{
    private readonly IProductRepository _repo;

    public ProductsController(IProductRepository repo)
    {
        _repo = repo;
    }

    public IActionResult Index()
    {
        return View(_repo.GetAll());
    }

    public IActionResult Details(int id)
    {
        return View(_repo.GetById(id));
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Product product)
    {
        _repo.Add(product);
        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
        return View(_repo.GetById(id));
    }

    [HttpPost]
    public IActionResult Edit(Product product)
    {
        _repo.Update(product);
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        return View(_repo.GetById(id));
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        _repo.Delete(id);
        return RedirectToAction("Index");
    }
}