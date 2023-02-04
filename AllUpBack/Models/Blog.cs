using AllUpBack.Interfaces;

namespace AllUpBack.Models
{
    public class Blog:ITime
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int MyProperty { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;
        public DateTime UpdateTime { get; set; } = DateTime.Now;
        public DateTime DeleteTime { get; set; } = DateTime.Now;
    }
}
