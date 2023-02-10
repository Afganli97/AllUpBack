using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllUpBack.Areas.AdminArea.ViewModels;
using AllUpBack.DAL;
using AllUpBack.Models;
using FrontToBack.Helpers.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AllUpBack.Areas.AdminArea.Controllers
{
    [Area("adminarea")]
    //[Authorize(Roles = "admin")]
    public class ProductController : Controller
    {
        private readonly DataBase _context;
private readonly IWebHostEnvironment _env;

        public ProductController(DataBase context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            return View(_context.Products.Include(p=>p.Images).ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.Where(x=>!x.IsDeleted).ToList();
            ViewBag.Colors = _context.Colors.ToList();
            ViewBag.Sizes = _context.Sizes.ToList();
            ViewBag.Compositions = _context.Compositions.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductCreateVM productVM, int? categoryId)
        {
            ViewBag.Colors = _context.Colors.ToList();
            ViewBag.Sizes = _context.Sizes.ToList();
            ViewBag.Compositions = _context.Compositions.ToList();
            ViewBag.Categories = _context.Categories.Where(x=>!x.IsDeleted).ToList();

            if (!ModelState.IsValid) return View();

            if(categoryId == null) return NotFound();

            if (_context.Categories.Find(categoryId) == null) return NotFound();

            if (_context.Products.Any(c=>c.ProductName.ToLower() == productVM.Product.ProductName.ToLower()))
            {
                ModelState.AddModelError("Name", "This name already exist!");
                return View();
            }

            if (ModelState["Photos"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                return View();

            // if (!_context.Colors.Any(x=>x.ColorName.ToLower() == productVM.Color.ToLower()))
            // {
            //     ModelState.AddModelError("Color", "This color does not exist!");
            //     return View();
            // }

            productVM.Product.CategoryId = (int)categoryId;
            _context.Products.Add(productVM.Product);
            _context.SaveChanges();

            ProductColor productColor = new ProductColor();
            ProductSize productSize = new ProductSize();
            ProductComposition productComposition = new ProductComposition();

            productColor.Product = productVM.Product;
            //productColor.Color = _context.Colors.FirstOrDefault(x=>x.ColorName.ToLower() == productVM.Color.ToLower());
            productSize.Product = productVM.Product;

            if (productVM.Tag != null)
            {
                var tags = productVM.Tag.Split();
                foreach (var item in tags)
                {
                    Tag tag = new Tag();
                    tag.TagName = item;

                    ProductTag productTag = new ProductTag();
                    productTag.Tag = tag;
                    productTag.Product = productVM.Product;
                    
                    _context.Tags.Add(tag);
                    _context.ProductTags.Add(productTag);
                }
            }

            foreach (var photo in productVM.Photos)
            {
                if(!photo.CheckFile("image"))
                    ModelState.AddModelError("Photo", "Select Photo");
                if(photo.CheckFileLength(10000))
                    ModelState.AddModelError("Photo", "Selected photo length is so much");


                photo.SaveFile(_env, "assets/images/product");

                Image image = new Image();

                image.ImageUrl = photo.FileName;
                image.Product = productVM.Product;
                if (photo == productVM.Photos.Last())
                    image.IsMain = true;
                _context.Images.Add(image);
            }
            
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        // public IActionResult Detail(int? id)
        // {
        //     if(id == null) return NotFound();
        //     Product product = _context.Products.Include(p=>p.Images).Include(p=>p.Category).FirstOrDefault(x=>x.Id == id);
        //     if(product == null) return NotFound();

        //     return View(product);
        // }

        // public IActionResult Delete(int? id)
        // {
        //     if(id == null) return NotFound();
        //     Product product = _context.Products.Include(p=>p.Images).Include(p=>p.Category).FirstOrDefault(x=>x.Id == id);
        //     if(product == null) return NotFound();

        //     _context.Products.Remove(product);
        //     _context.SaveChanges();
            
        //     return RedirectToAction("Index");
        // }

        // public IActionResult Update(int? id)
        // {
        //     if(id == null) return NotFound();
        //     Product product = _context.Products.Include(p=>p.Images).Include(p=>p.Category).FirstOrDefault(x=>x.Id == id);
        //     if(product == null) return NotFound();

        //     return View(product);
        // }

        // [HttpPost]
        // public IActionResult Update(int? id, Product product)
        // {
        //     if(!ModelState.IsValid) return View();
        //     var existProduct = _context.Products.Find(id);
        //     if (!_context.Products.Any(x=>x.Name.ToLower() == product.Name.ToLower())&&existProduct.Name.ToLower()!=product.Name.ToLower()) return View();

        //     var mainImage = product.Images.FirstOrDefault(x=>x.IsMain);

        //     existProduct.Name = product.Name;
        //     existProduct.Price = product.Price;
        //     existProduct.Count = product.Count;

        //     if (mainImage.Photo != null)
        //     {
        //         if(!mainImage.Photo.CheckFile("image"))
        //             ModelState.AddModelError("Photo", "Select Photo");
        //         if(mainImage.Photo.CheckFileLength(1000))
        //             ModelState.AddModelError("Photo", "Selected photo length is so much");

        //         existProduct.Images.FirstOrDefault(x=>x.IsMain).ImageUrl.DeleteFile(_env, "img");
        //         mainImage.Photo.SaveFile(_env, "img");
                
        //         _context.Products.Find(id).Images.FirstOrDefault(x=>x.IsMain).ImageUrl = mainImage.Photo.FileName;
        //         _context.SaveChanges();
        //     }

        //     _context.Products.Update(existProduct);
        //     _context.SaveChanges();

        //     return RedirectToAction("Index");
        // }
        
    }
}