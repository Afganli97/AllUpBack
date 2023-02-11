using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllUpBack.ViewModels
{
    public class PaginationVM<T>
    {
        public List<T> Items { get; set; }
        public List<T> TakedItems { get; set; }
        public int ExistPage { get; set; }
        public int Take { get; set; }

        public int CalculatePageCount()
        {
            return (int)Math.Ceiling((double)Items.Count/(double)Take);
        }
    }
}