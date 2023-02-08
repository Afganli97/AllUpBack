using AllUpBack.DAL;
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

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("Default");
        }
    }
}