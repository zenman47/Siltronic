using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LiveCensus.Models
{
    public class Team1
    {
        public int id { get; set; }

        [Display(Name = "Date")]
        public virtual effdt effdt { get; set; }

        [Display(Name = "Hour")]
        public virtual hour hour { get; set; }

        [Display(Name = "Shift")]
        public virtual shift shift { get; set; }

        [Display(Name="Cell 1")]
        public int cell1 { get; set; }

        [Display(Name = "Cell 2")]
        public int cell2 { get; set; }

        [Display(Name = "Cell 3")]
        public int cell3 { get; set; }

        [Display(Name = "Cell 4")]
        public int cell4 { get; set; }

        [Display(Name = "Cell 6")]
        public int cell6 { get; set; }

        [Display(Name = "Cell 7")]
        public int cell7 { get; set; }
       
        public string CreatedBy { get; set; }

        public string EditedBy { get; set; }

        public DateTime EditDt { get; set; }
    }
}