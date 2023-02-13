using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AllUpBack.DAL;
using AllUpBack.Models;
using AllUpBack.ViewModels;
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

        public IActionResult Index(ProductVM productVM)
        {   
            ViewBag.Sizes = _context.Sizes.Include(x=>x.ProductCounts).ToList();
            ViewBag.Colors = _context.Colors.Include(x=>x.ProductCounts).ToList();
            ViewBag.Compositions = _context.Compositions.Include(x=>x.ProductCounts).ToList();

            var allProducts = _context.Products.Include(x=>x.Images).Include(x=>x.ProductCounts).ToList();

            if (productVM.CategoryId == null)
            {
                ViewBag.Categories = _context.Categories.ToList();
                if (productVM.IsFiltered && productVM.Colors.Count != 0 && productVM.Compositions.Count != 0 && productVM.Sizes.Count != 0)
                {
                    productVM.Products = Filter(allProducts, productVM.Colors, productVM.Sizes, productVM.Compositions, productVM.Price);
                }
                else
                {
                    productVM.Products = allProducts;
                }
                return View(productVM);
            }

            var category = _context.Categories.Include(x=>x.Products).ThenInclude(x=>x.ProductCounts).FirstOrDefault(x=>x.Id == productVM.CategoryId);

            if(category==null)
            {
                ViewBag.Categories = _context.Categories.ToList();
                if (productVM.IsFiltered && productVM.Colors.Count != 0 && productVM.Compositions.Count != 0 && productVM.Sizes.Count != 0)
                {
                    productVM.Products = Filter(allProducts, productVM.Colors, productVM.Sizes, productVM.Compositions, productVM.Price);
                }
                else
                {
                    productVM.Products = allProducts;
                }
                return View(productVM);
            }

            ViewBag.Category = _context.Categories.Include(x=>x.SubCategories).FirstOrDefault(x=>x.Id == productVM.CategoryId);

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

            if (productVM.IsFiltered && productVM.Colors.Count != 0 && productVM.Compositions.Count != 0 && productVM.Sizes.Count != 0)
            {
                productVM.Products = Filter(desiredProducts, productVM.Colors, productVM.Sizes, productVM.Compositions, productVM.Price);
            }
            else
            {
                productVM.Products = desiredProducts;
            }

            return View(productVM);
        }

        public IActionResult Detail()
        {
            return View();
        }

        public static List<Product> Filter(List<Product> allProducts, Dictionary<int, bool> colors,Dictionary<int, bool> sizes, Dictionary<int, bool> compositions, string price)
        {
            List<Product> existProducts = new();

            var prices = price.Split();
            string minPrice = string.Empty;
            string maxPrice = string.Empty;
            var first = true;

            foreach (var item in prices[0])
            {
                if (first)
                first = false;
                else
                {
                    minPrice += item;
                }
            }
            first = true;
            foreach (var item in prices[2])
            {
                if (first)
                first = false;
                else
                {
                    maxPrice += item;
                }
            }

            int minPriceInt = Int32.Parse(minPrice);
            int maxPriceInt = Int32.Parse(maxPrice);




            foreach (var item in allProducts)
            {
                foreach (var productCount in item.ProductCounts)
                {
                    if (colors.Any(x=>x.Key == productCount.ColorId) && sizes.Any(x=>x.Key == productCount.SizeId) && compositions.Any(x=>x.Key==productCount.CompositionId) && item.Price >= minPriceInt && item.Price <= maxPriceInt)
                    {
                        existProducts.Add(productCount.Product);
                    }
                }
            }
            return existProducts;
        }
    }
}