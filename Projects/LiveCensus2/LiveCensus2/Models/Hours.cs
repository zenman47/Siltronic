namespace LiveCensus2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APP_OWNER.LCEN_HOURS")]
    public partial class Hours
    {
        public Hours()
        {
            LCEN_TEAM1 = new HashSet<Team1>();
        }

        [Key]
        public decimal HOUR_ID { get; set; }

        [StringLength(4)]
        public string HRNUM { get; set; }

        [StringLength(20)]
        public string HRDISP { get; set; }

        public decimal? SHIFT { get; set; }

        public virtual Shifts LCEN_SHIFTS { get; set; }

        public virtual ICollection<Team1> LCEN_TEAM1 { get; set; }
    }
}
