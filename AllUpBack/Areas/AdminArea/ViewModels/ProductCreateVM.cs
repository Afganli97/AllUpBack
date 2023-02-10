using AllUpBack.Models;

namespace AllUpBack.Areas.AdminArea.ViewModels
{
    public class ProductCreateVM
    {
        public string Tag { get; set; }
        public Product Product { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
        public Composition Composition { get; set; }
        public Category Category { get; set; }
        public List<IFormFile> Photos { get; set; }

    }
}