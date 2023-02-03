using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllUpBack.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public bool IsMain { get; set; }

        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}