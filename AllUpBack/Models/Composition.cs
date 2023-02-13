using AllUpBack.DAL;

namespace AllUpBack.Models
{
    public class Composition
    {
        public Composition()
        {
            ProductCounts = new();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductCount> ProductCounts { get; set; }
    }
}