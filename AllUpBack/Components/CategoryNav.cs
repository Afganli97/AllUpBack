using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllUpBack.DAL;
using Microsoft.AspNetCore.Mvc;

namespace AllUpBack.Components
{
    public class CategoryNav : ViewComponent
    {
        private readonly DataBase _context;

        public CategoryNav(DataBase context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(string arg)
        {
            return View(arg, _context.Categories.ToList());
        }
    }
}