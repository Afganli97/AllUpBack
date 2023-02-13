using AllUpBack.Models;

namespace AllUpBack.ViewModels
{
    public class ProductVM
    {
        public ProductVM()
        {
            Products = new();
            Pagination = new();
            Pagination.Items = new();
        }
        public int? CategoryId { get; set; }
        public int? ColorId { get; set; }
        public bool IsFiltered { get; set; }
        public string Price { get; set; }
        public List<Product> Products { get; set; }
        public Dictionary<int,bool> Sizes { get; set; }
        public Dictionary<int,bool> Colors { get; set; }
        public Dictionary<int,bool> Compositions { get; set; }
        public PaginationVM<Product> Pagination { get; set; }

    }
}