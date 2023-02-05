using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AllUpBack.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string ProductDesc { get; set; }
        public string Text { get; set; }
        
        [ForeignKey(nameof(Product))]
        public int? ProductId { get; set; }
        public Product Product { get; set; }
        public Image Image { get; set; }
        
    }
}