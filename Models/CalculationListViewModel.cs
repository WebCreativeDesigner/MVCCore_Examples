using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore_Examples.Models
{
    public class CalculatedListViewModel
    {
        public List<decimal> RawData { set; get; }
        public List<decimal> CalculatedData { set; get; }
    }
}
