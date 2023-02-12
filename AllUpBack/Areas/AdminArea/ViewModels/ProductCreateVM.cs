using AllUpBack.Models;

namespace AllUpBack.Areas.AdminArea.ViewModels
{
    public class ProductCreateVM
    {
        public string Tag { get; set; }
        public int Count { get; set; }
        public int CategoryId { get; set; }
        public string Brand { get; set; }
        public Product Product { get; set; }
        public Color Color { get; set; }
        public Composition Composition { get; set; }
        public Category Category { get; set; }
        public Dictionary<int, int> Sizes { get; set; }
        public List<IFormFile> Photos { get; set; }
        

    }
}