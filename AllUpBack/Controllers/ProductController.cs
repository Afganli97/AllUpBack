using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AllUpBack.DAL;
using AllUpBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AllUpBack.Controllers
{
    public class ProductController : Controller
    {
        private readonly DataBase _context;

        public ProductController(DataBase context)
        {
            _context = context;
        }

        public IActionResult Index(int? categoryId)
        {   
            var allProducts = _context.Products.Include(x=>x.Images).ToList();

            if (categoryId == null) return View(allProducts);
            var category = _context.Categories.Where(x=>x.IsDeleted == false).Include(x=>x.Products).ThenInclude(x=>x.Images).Include(c=>c.SubCategories).ThenInclude(x=>x.SubCategories).Where(x=>x.IsDeleted == false).FirstOrDefault(x=>x.Id == categoryId);
            if(category==null) return View(allProducts);

            var desiredProducts = new List<Product>();
            
            if(category.Products != null) desiredProducts.AddRange(category.Products);

            if (category.SubCategories != null)
            {   
                foreach (var item in category.SubCategories)
                {
                    if(item.Products != null) desiredProducts.AddRange(item.Products);
                    if (item.SubCategories != null)
                    {   
                        foreach (var sub in item.SubCategories)
                        {
                            if(sub.Products != null) desiredProducts.AddRange(sub.Products);
                        }
                    }
                }
            }
            return View(desiredProducts);
        }

         public IActionResult Detail()
        {
            return View();
        }
    }
}