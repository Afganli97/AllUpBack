using AllUpBack.DAL;
using AllUpBack.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace AllUpBack.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    //[Authorize(Roles = "admin")]
    public class CategoryController : Controller
    {
        private readonly DataBase _context;

        public CategoryController(DataBase context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            if(categories == null) return View();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
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
            return RedirectToAction("Index");
        }

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
