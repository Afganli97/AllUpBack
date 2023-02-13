using AllUpBack.DAL;
using AllUpBack.Models;
using AllUpBack.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AllUpBack.Components
{
    public class ProductSlideBar : ViewComponent
    {
        private readonly DataBase _context;

        public ProductSlideBar(DataBase context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(ProductVM productVM)
        {
            
            return View("Default", productVM);
        }
    }
}