namespace LiveCensus.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APP_OWNER.LCEN_TEAM1")]
    public partial class LCEN_TEAM1
    {
        public decimal ID { get; set; }

        public DateTime EFFDT { get; set; }

        [StringLength(2)]
        public string HOUR { get; set; }

        [StringLength(1)]
        public string SHIFT { get; set; }

        [StringLength(20)]
        public string CREATEDBY { get; set; }

        public DateTime? CREATEDDT { get; set; }

        [StringLength(20)]
        public string EDITEDBY { get; set; }

        public DateTime? EDITEDDT { get; set; }

        public decimal? CELL1 { get; set; }

        public decimal? CELL2 { get; set; }

        public decimal? CELL3 { get; set; }

        public decimal? CELL4 { get; set; }

        public decimal? CELL6 { get; set; }

        public decimal? CELL7 { get; set; }
    }
}
