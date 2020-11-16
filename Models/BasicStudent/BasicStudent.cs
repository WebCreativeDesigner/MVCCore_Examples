using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore_Examples.Models.BasicStudent
{
    public class BasicStudent
    {
        public int StudentId { get; set; }

        [Display(Name = "Name")]
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}
