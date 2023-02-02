using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllUpBack.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int? SliderId { get; set; }
        public Slider Slider { get; set; }
        public int? BannerId { get; set; }
        public Banner Banner { get; set; }
    }
}