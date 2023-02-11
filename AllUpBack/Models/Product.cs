using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AllUpBack.Helpers;
using Microsoft.EntityFrameworkCore;

namespace AllUpBack.Models
{
    public class Product : ModifyTime
    {
        public Product()
        {
            IsDeleted = false;
            CreatedTime = DateTime.Now;
            LastModifiedTime = DateTime.Now;
            ProductTags = new();
            Images = new();
            ProductCounts = new();
        }
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Image> Images { get; set; }
        public List<ProductTag> ProductTags { get; set; }
        public Slider Slider { get; set; }
        public Banner Banner { get; set; }
        public List<ProductCount> ProductCounts { get; set; }

    }
}