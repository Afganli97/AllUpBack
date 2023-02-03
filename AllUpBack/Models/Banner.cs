using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AllUpBack.Models
{
    public class Banner
    {
        public int Id { get; set; }
        public string Url { get; set; }
        
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }
    }
}