using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AllUpBack.Helpers;
using AllUpBack.Interfaces;

namespace AllUpBack.Models
{
    public class Blog : ModifyTime
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int MyProperty { get; set; }
        public List<Image> Images { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
