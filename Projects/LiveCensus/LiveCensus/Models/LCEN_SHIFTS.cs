namespace LiveCensus.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APP_OWNER.LCEN_SHIFTS")]
    public partial class LCEN_SHIFTS
    {
        public decimal ID { get; set; }

        [StringLength(1)]
        public string SHIFTNUM { get; set; }

        [StringLength(8)]
        public string SHIFTDISP { get; set; }
    }
}
