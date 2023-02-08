using AllUpBack.DAL;
using AllUpBack.Models;
using AllUpBack.ViewModels;
using FrontToBack.Helpers.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace AllUpBack.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    //[Authorize(Roles = "admin")]
    public class CategoryController : Controller
    {
        private readonly DataBase _context;
        private readonly IWebHostEnvironment _env;

        public CategoryController(DataBase context, IWebHostEnvironment env = null)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            var categories = _context.Categories.ToList(); 
            foreach (var item in categories)
            {
                foreach (var sub in categories)
                {
                    if (item.Id == sub.MainCategory)
                    {
                        item.SubCategories.Add(sub);
                    }
                }
            }
            return View(categories);
        }

        public IActionResult Create()
        {
            var categories = _context.Categories.ToList(); 
            foreach (var item in categories)
            {
                foreach (var sub in categories)
                {
                    if (item.Id == sub.MainCategory)
                    {
                        item.SubCategories.Add(sub);
                    }
                }
            }
            return View(categories);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Category category)
        {
            if (!ModelState.IsValid) return View();
            if (_context.Categories.Any(c=>c.CategoryName.ToLower() == category.CategoryName.ToLower()))
            {
                ModelState.AddModelError("Name", "This name already exist!");
                return View();
            }
            
            
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("AddPhoto", new {id = });
        }

        // public IActionResult AddPhoto(IFormFile photo)
        // {
        //     if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
        //         return View();
        //     if(!category.Image.Photo.CheckFile("image"))
        //         ModelState.AddModelError("Photo", "Select Photo");
        //     if(category.Image.Photo.CheckFileLength(1000))
        //         ModelState.AddModelError("Photo", "Selected photo length is so much");

        //     category.Image.Photo.SaveFile(_env, "img");
        //     category.Image.ImageUrl = category.Image.Photo.FileName;
        //     category.Image.IsMain = true;
        // }

        public IActionResult Info(int? id)
        {
            // if (id == null) return NotFound();
            // var category = _context.Categories.Find(id);
            // if (category == null) return NotFound();

            // return View(category);
            return View();
        }

        public IActionResult Update(int? id)
        {
            // if (id == null) return NotFound();
            // var category = _context.Categories.Find(id);
            // if (category == null) return NotFound();

            // return View(category);
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update()
        {
            // if (!ModelState.IsValid) return View();
            // if (_context.Categories.Any(c=>c.Name.ToLower() == category.Name.ToLower()))
            // {
            //     ModelState.AddModelError("Name", "This name already exist!");
            //     return View(category);
            // }
            // _context.Categories.Find(category.Id).Name = category.Name;
            // _context.Categories.Find(category.Id).Description = category.Description;
            // _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            // if (id == null) return NotFound();
            // var category = _context.Categories.Find(id);
            // if (category == null) return NotFound();

            // return View(category);
            return View();
        }

        [HttpPost]
        public IActionResult Delete()
        {
            // _context.Categories.Remove(category);
            // _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
