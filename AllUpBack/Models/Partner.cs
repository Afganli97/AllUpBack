using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllUpBack.Models
{
    public class Partner
    {
        public int Id { get; set; }
        public List<Image> Images { get; set; }
    }
}
