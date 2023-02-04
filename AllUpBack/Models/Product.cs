using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AllUpBack.Models
{
    public class Product
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
        public List<Tag> Tags { get; set; }
        public Slider Slider { get; set; }
        public Banner Banner { get; set; }



    }
}