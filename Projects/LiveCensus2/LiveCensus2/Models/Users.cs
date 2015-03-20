namespace LiveCensus2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APP_OWNER.LCEN_USERS")]
    public partial class Users
    {
        public Users()
        {
            LCEN_TEAM1 = new HashSet<Team1>();
            LCEN_TEAM11 = new HashSet<Team1>();
        }

        [Key]
        [StringLength(6)]
        public string USERID { get; set; }

        [StringLength(20)]
        public string FIRST_NAME { get; set; }

        [StringLength(20)]
        public string LAST_NAME { get; set; }

        [StringLength(50)]
        public string FULL_NAME { get; set; }

        [StringLength(100)]
        public string USER_EMAIL { get; set; }

        public decimal? USER_ROLE { get; set; }

        [StringLength(1)]
        public string STATUS { get; set; }

        public virtual Roles LCEN_ROLES { get; set; }

        public virtual ICollection<Team1> LCEN_TEAM1 { get; set; }

        public virtual ICollection<Team1> LCEN_TEAM11 { get; set; }
    }
}
