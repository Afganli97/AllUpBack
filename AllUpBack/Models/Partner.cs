using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllUpBack.Models
{
    public class Partner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Image Image { get; set; }
    }
}
