using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore_Examples.Models
{
    public class CalculatedDataModel
    {
        public int Id { get; set; }
        public decimal RawData { get; set; }
        public decimal c { get; set; }
        public decimal m { get; set; }
        public decimal Calculated { get; set; }
    }
}
