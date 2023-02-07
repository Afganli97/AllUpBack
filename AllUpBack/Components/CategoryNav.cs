using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllUpBack.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AllUpBack.Components
{
    public class CategoryNav : ViewComponent
    {
        private readonly DataBase _context;

        public CategoryNav(DataBase context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await _context.Categories.ToListAsync();
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
    }
}