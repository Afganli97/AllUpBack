using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AllUpBack.Helpers;
using Microsoft.EntityFrameworkCore;

namespace AllUpBack.Models
{
    public class Product : ModifyTime
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }
        public int Stars { get; set; }
        public int Count { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public List<Image> Images { get; set; }
        public List<ProductTag> ProductTags { get; set; }
        public Slider Slider { get; set; }
        public Banner Banner { get; set; }
        public List<ProductColor> ProductColors { get; set; }
        public List<ProductSize> ProductSizes { get; set; }
        public List<ProductComposition> ProductCompositions { get; set; }

    }
}