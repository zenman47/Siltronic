using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LiveCensus.Models
{
    [Table("LCEN_TEAM2")]
    public class Team2
    {
        public int id { get; set; }

        public DateTime effdt { get; set; } 

        public virtual hour hour { get; set; }

        public virtual shift shift { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDt { get; set; }

        public string EditedBy { get; set; }

        public DateTime EditedDt { get; set; }

        public int cell5 { get; set; }

        public int cell8 { get; set; }

        public int cell9 { get; set; }

    }
}