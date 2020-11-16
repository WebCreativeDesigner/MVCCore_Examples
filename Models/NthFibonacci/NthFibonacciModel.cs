using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore_Examples.Models.NthFibonacci
{
    public class NthFibonacciModel
    {
        public int Id { get; set; }
        [DisplayName("Number")]
        public decimal Number { get; set; }
        public decimal CalculatedNumber1 { get; set; }
        public decimal CalculatedNumber2 { get; set; }
        public Boolean NthFibonacciType { get; set; }
    }
}
