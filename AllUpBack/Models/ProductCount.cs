using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllUpBack.Models
{
    public class ProductCount
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ColorId { get; set; }
        public int SizeId { get; set; }
        public int CompositionId { get; set; }
        public int Count { get; set; }
        public Product Product { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
        public Composition Composition { get; set; }
    }
}