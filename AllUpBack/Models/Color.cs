using AllUpBack.DAL;

namespace AllUpBack.Models
{
    public class Color
    {
        public Color()
        {
            ProductCounts = new();
            
        }
        public int Id { get; set; }
        public string ColorName { get; set; }
        public string ColorBootstrapClass { get; set; }
        public List<ProductCount> ProductCounts { get; set; }

    }
}