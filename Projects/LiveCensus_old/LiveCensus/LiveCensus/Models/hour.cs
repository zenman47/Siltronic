using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace LiveCensus.Models
{
    public class hour
    {
        public int HourID { get; set; }

        [Display(Name = "Hour")]
        public string hourDescr { get; set; }

        [Display(Name = "Hour")]
        public string TimeDisp { get; set; }
    }
}
