using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AllUpBack.Helpers;

namespace AllUpBack.Models
{
    public class Category : ModifyTime
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int? MainCategory { get; set; }
        public Image Image { get; set; }
        public List<Product> Products { get; set; }

    }
}