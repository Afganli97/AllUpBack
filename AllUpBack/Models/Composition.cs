namespace AllUpBack.Models
{
    public class Composition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductComposition> ProductCompositions { get; set; }
    }
}