namespace LiveCensus.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APP_OWNER.LCEN_HOURS")]
    public partial class LCEN_HOURS
    {
        public decimal ID { get; set; }

        [StringLength(4)]
        public string HRNUM { get; set; }

        [StringLength(20)]
        public string HRDISP { get; set; }

        [StringLength(1)]
        public string SHIFT { get; set; }
    }
}
