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
        homeVM.Sliders = _context.Sliders.ToList();
        homeVM.Banners = _context.Banners.ToList();
        homeVM.Categories = _context.Categories.ToList();
        homeVM.Products = _context.Products.Include(x=>x.Images).ToList();
        homeVM.Blogs = _context.Blogs.ToList();
        homeVM.Partners = _context.Partners.ToList();
        return View(homeVM);
    }
}

