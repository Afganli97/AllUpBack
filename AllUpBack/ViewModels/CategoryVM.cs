using AllUpBack.Models;

namespace AllUpBack.ViewModels
{
    public class CategoryVM
    {
        public int CategoryId { get; set; }
        public List<Category> Categories { get; set; }
        public Category Category { get; set; }
    }
}