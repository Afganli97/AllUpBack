using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllUpBack.Helpers
{
    public class ModifyTime
    {
        public DateTime CreatedTime { get; set; }
        public DateTime LastModifiedTime { get; set; }
        public DateTime? DeletedTime { get; set; }
    }
}