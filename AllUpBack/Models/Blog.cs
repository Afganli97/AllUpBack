using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AllUpBack.Helpers;

namespace AllUpBack.Models
{
    public class Blog : ModifyTime
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public List<Image> Images { get; set; }
        public List<BlogTag> BlogTags { get; set; }
    }
}
