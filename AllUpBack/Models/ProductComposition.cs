namespace AllUpBack.Models
{
    public class ProductComposition
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CompositionId { get; set; }
        public Composition Composition { get; set; }
    }
}