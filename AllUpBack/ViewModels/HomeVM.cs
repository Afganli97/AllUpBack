using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllUpBack.Models;

namespace AllUpBack.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Banner> Banners { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<Image> Images { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Partner> Partners { get; set; }




    }
}