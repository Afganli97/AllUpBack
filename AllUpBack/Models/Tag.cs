using System.ComponentModel.DataAnnotations.Schema;

namespace AllUpBack.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string TagName { get; set; }
        public List<ProductTag> ProductTags { get; set; }
        public List<BlogTag> BlogTags { get; set; }

    }
}