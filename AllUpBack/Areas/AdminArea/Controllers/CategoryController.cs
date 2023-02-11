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

        public IActionResult Index(int take = 10, int skip = 1)
        {
            var categories = _context.Categories; 
            PaginationVM<Category> paginationVM = new();
            paginationVM.Items = categories.ToList();
            paginationVM.TakedItems = categories.Skip(take*(skip-1)).Take(take).ToList();
            paginationVM.Take = take;
            paginationVM.ExistPage = skip;

            return View(paginationVM);
        }

        public IActionResult Create()
        {
            var categories = _context.Categories.Where(x=>x.IsDeleted == false).ToList(); 
            
            return View(categories);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(Category category, IFormFile Photo)
        {
            if (!ModelState.IsValid) return View();
            if (_context.Categories.Any(c=>c.CategoryName.ToLower() == category.CategoryName.ToLower()))
            {
                ModelState.AddModelError("Name", "This name already exist!");
                return View();
            }

            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                return View();
            if(!Photo.CheckFile("image"))
                ModelState.AddModelError("Photo", "Select Photo");
            if(Photo.CheckFileLength(10000))
                ModelState.AddModelError("Photo", "Selected photo length is so much");

            category.Image = new Image();

            Photo.SaveFile(_env, "assets/images");
            category.Image.ImageUrl = Photo.FileName;
            category.Image.IsMain = true;
            
            
            
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult AddPhoto(int? id)
        {
            if (id == null) return View();
            return View(id);
        }

        public IActionResult Info(int? id)
        {
            if (id == null) return NotFound();
            var category = _context.Categories.Find(id);
            if (category == null) return NotFound();

            return View(category);
        }

        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            var category = _context.Categories.Find(id);
            if (category == null) return NotFound();

            return View(category);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(Category category)
        {
            if (!ModelState.IsValid) return View();
            if (_context.Categories.Any(c=>c.CategoryName.ToLower() == category.CategoryName.ToLower()))
            {
                ModelState.AddModelError("Name", "This name already exist!");
                return View(category);
            }
            _context.Categories.Find(category.Id).CategoryName = category.CategoryName;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var category = _context.Categories.Include(x=>x.Image).FirstOrDefault(x=>x.Id == id);
            if (category == null) return NotFound();

            category.IsDeleted = true;
            category.DeletedTime = DateTime.Now;
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
