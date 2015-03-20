namespace LiveCensus2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APP_OWNER.LCEN_SHIFTS")]
    public partial class Shifts
    {
        public Shifts()
        {
            LCEN_HOURS = new HashSet<Hours>();
            LCEN_TEAM1 = new HashSet<Team1>();
        }

        [Key]
        public decimal SHIFT_ID { get; set; }

        [StringLength(1)]
        public string SHIFTNUM { get; set; }

        [StringLength(8)]
        public string SHIFTDISP { get; set; }

        public virtual ICollection<Hours> LCEN_HOURS { get; set; }

        public virtual ICollection<Team1> LCEN_TEAM1 { get; set; }
    }
}
