using AllUpBack.DAL;

namespace AllUpBack.Models
{
    public class Size
    {
        public Size()
        {
            ProductCounts = new();
        }
        public int Id { get; set; }
        public string SizeName { get; set; }
        public List<ProductCount> ProductCounts { get; set; }

    }
}