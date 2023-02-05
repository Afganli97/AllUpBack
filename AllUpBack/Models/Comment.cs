using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllUpBack.Helpers;

namespace AllUpBack.Models
{
    public class Comment : ModifyTime
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string AuthorName { get; set; }
    }
}