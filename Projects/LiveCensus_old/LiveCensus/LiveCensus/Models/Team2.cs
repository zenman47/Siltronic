using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LiveCensus.Models
{
    public class Team2
    {
        public int id { get; set; }

        [Display(Name = "Date")]
        public virtual effdt effdt { get; set; }

        [Display(Name = "Hour")]
        public virtual hour hour { get; set; }

        [Display(Name = "Shift")]
        public virtual shift shift { get; set; }

        [Display(Name = "Cell 5")]
        public int cell5 { get; set; }

        [Display(Name = "Cell 8")]
        public int cell8 { get; set; }

        [Display(Name = "Cell 9")]
        public int cell9 { get; set; }

        public string CreatedBy { get; set; }

        public string EditedBy { get; set; }

        public DateTime EditDt { get; set; }

       
    }
}