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
        public int? ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey(nameof(Blog))]
        public int? BlogId { get; set; }
        public Blog Blog { get; set; }

        [ForeignKey(nameof(Partner))]
        public int? PartnerId { get; set; }
        public Partner Partner { get; set; }

        [ForeignKey(nameof(Category))]
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

    }
}