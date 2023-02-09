using System.Diagnostics;
using AllUpBack.DAL;
using AllUpBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AllUpBack.Controllers;

public class HomeController : Controller
{
    private readonly DataBase _context;

    public HomeController(DataBase context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        HomeVM homeVM =  new HomeVM();
        homeVM.Sliders = _context.Sliders.Include(x=>x.Image).ToList();
        homeVM.Banners = _context.Banners.Include(x=>x.Image).ToList();
        homeVM.Products = _context.Products.Include(x=>x.Images).ToList();
        homeVM.Blogs = _context.Blogs.Include(x=>x.Images).ToList();
        homeVM.Partners = _context.Partners.Include(x=>x.Image).ToList();

        foreach (var item in _context.Categories.Include(x=>x.SubCategories).ToList())
        {
            if (item.SubCategories != null)
            {
                homeVM.Categories.AddRange(item.SubCategories);
            }
        }
        return View(homeVM);
    }
}

