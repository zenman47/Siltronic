using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LiveCensus.Models
{
    [Table("LCEN_TEAM1")]
    public class Team1
    {
        public int id { get; set; }

        public DateTime effdt { get; set; }

        public virtual hour hour { get; set; }

        public virtual shift shift  { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDt { get; set; }

        public string EditedBy { get; set; }

        public DateTime EditedDt { get; set; }

        public int cell1 { get; set; }

        public int cell2 { get; set; }

        public int cell3 { get; set; }

        public int cell4 { get; set; }

        public int cell6 { get; set; }

        public int cell7 { get; set; }



    }
}