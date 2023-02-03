using System.ComponentModel.DataAnnotations.Schema;

namespace AllUpBack.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string TagName { get; set; }
        
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}