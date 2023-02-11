namespace AllUpBack.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
        public string ColorBootstrapClass { get; set; }
        public List<ProductCount> ProductCounts { get; set; }

    }
}